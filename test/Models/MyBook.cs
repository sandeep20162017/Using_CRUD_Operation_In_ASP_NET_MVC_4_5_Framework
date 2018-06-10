using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace BookManagmentMVC.Models
{
    public class MyBook
    {
        public int Id
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please Enter BookName")]
        public string BookName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please Enter AuthorName")]
        public string AuthorName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please Enter Price")]
        public int BookPrice
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please Enter Bookpublish")]
        public string BookPublish
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please Enter Comments")]
        public string Comments
        {
            get;
            set;
        }
    }
}