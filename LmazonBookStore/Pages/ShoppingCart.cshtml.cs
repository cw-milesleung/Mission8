﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LmazonBookStore.Infrastrusture;
using LmazonBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LmazonBookStore.Pages
{
    public class ShoppingCartModel : PageModel
    {

        private IBookStoreRepository repo { get; set; }

        public ShoppingCartModel (IBookStoreRepository temp)
        {
            repo = temp;
        }

        public Basket basket { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Books b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();

            basket.AddItem(b, 1);

            HttpContext.Session.SetJson("basket", basket);

            return RedirectToPage(new {ReturnUrl = returnUrl });

        }
    }
}
