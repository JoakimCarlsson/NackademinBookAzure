using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NackademinBookAzure.ViewModels
{
    public class BookListIndexViewModel
    {
        public List<BookIndexViewModel> Books { get; set; } = new();
    }
}
