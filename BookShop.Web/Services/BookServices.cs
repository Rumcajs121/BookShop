﻿using BookShop.Web.Pages;
using Newtonsoft.Json;
using System.Diagnostics;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace BookShop.Web.Services
{
    public class BookServices: IBooksService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;
        private readonly EventService _eventService;

        public BookServices(HttpClient httpClient, ILocalStorageService localStorageService,EventService eventService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
            _eventService = eventService;
        }

        public async Task<List<ShoppingCart>> GetAllCart()
        {
            List<ShoppingCart> carts= await _localStorageService.GetItemAsync<List<ShoppingCart>>("cart");
            return carts;
        }

        public async Task AddToCart(BookDto book)
        {
            var cart = await GetAllCart();
            
            if (cart == null)
            {
                cart = new List<ShoppingCart>();
            }

            var cartItem = new ShoppingCart
            {
                BookId = book.Guid,
                Title = book.Title,
                OrginalPrice = book.Price,
                TotalPrice= book.Price,
                Image = book.Image,
                Quantity = 1
            };
            var existingItem = cart.FirstOrDefault(item => item.Equals(cartItem));
            if (existingItem != null)
            {
                existingItem.Quantity++;
                existingItem.TotalPrice = book.Price * (decimal)existingItem.Quantity;
            }
            else
            {
                cart.Add(cartItem);
            }

            await _localStorageService.SetItemAsync("cart", cart);
            _eventService.NotifyCartUpdated();
        }
        public async Task<int> ShopingCartCount()
        {
            var cartItems = await _localStorageService.GetItemAsync<List<ShoppingCart>>("cart");
            return cartItems?.Count ?? 0;
        }

        public async Task<List<ShoppingCart>> DeleteItem(ShoppingCart item)
        {
            var cart = await GetAllCart();
            if (cart == null)
            {
                return null;
            }
            var cartItem = cart.First(x=>x.BookId==item.BookId && x.Title==item.Title);
            cart.Remove(cartItem);
            await _localStorageService.SetItemAsync("cart", cart);
            _eventService.NotifyCartUpdated();
            return cart;
            
        }

        public async Task<List<ShoppingCart>> ChangeInputQuantityToCart(ShoppingCart item)
        {
            var cart = await GetAllCart();
            if (cart == null)
            {
                return null;
            }

            var cartItem = cart.FirstOrDefault(x => x.BookId == item.BookId && x.Title == item.Title);

            if (cartItem != null)
            {
                cartItem.Quantity = item.Quantity;
                cartItem.TotalPrice = cartItem.OrginalPrice * (decimal)item.Quantity;
                await _localStorageService.SetItemAsync("cart", cart);
                _eventService.NotifyCartUpdated();
            }
            return cart;

        }

        //Api call
        public async Task<List<BookDto>> GetAll()
        {
            var response = await _httpClient.GetAsync("BookShop/GetAll");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var books = JsonConvert.DeserializeObject<List<BookDto>>(content);
            return books;
        }



        public async Task<BookDto> GetBook(string guid)
        {
            
            var response = await _httpClient.GetAsync($"BookShop/GetBook/{guid}");
            var content=await response.Content.ReadAsStringAsync();
            var book=JsonConvert.DeserializeObject<BookDto>(content);
            return book;
        }


    }
}
