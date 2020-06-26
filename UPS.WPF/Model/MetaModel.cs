using System;
using System.Collections.Generic;
using System.Text;

namespace UPS.WPF.Model
{
    public class MetaModel : ModelBase
    {
        private int totalCount;
        private int pageCount;
        private int currentPage=1;

        public int TotalCount
        {
            get => totalCount; set
            {
                totalCount = value;
                OnPropertyChange();
            }
        }
        public int PageCount
        {
            get => pageCount; set
            {
                pageCount = value;
                OnPropertyChange();
            }
        }
        public int CurrentPage
        {
            get => currentPage; set
            {
                currentPage = value;
                OnPropertyChange();
            }
        }

       
        

    }
}
