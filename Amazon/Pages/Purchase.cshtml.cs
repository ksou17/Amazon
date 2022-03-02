using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Infrastructure;
using Amazon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Amazon.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookRepository repo { get; set; }
        public Basket Basket { get; set; }
        public string ReturnUrl { get; set; }

        public PurchaseModel (IBookRepository temp, Basket b)
        {
            repo = temp;
            Basket = b;
        }

       
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
    
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
        
            Basket.AddItem(b, 1);

            return RedirectToPage(new { ReturnUrl = returnUrl });

        }

        public IActionResult OnPostRemove (int bookId, string returnUrl)
        {
            Basket.RemoveItem(Basket.Items.First(x => x.Book.BookId == bookId).Book);
            return RedirectToPage (new { ReturnUrl = returnUrl });
        }
    }
}
