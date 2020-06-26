using System;
using System.Collections.Generic;
using System.Text;
using UPS.Entities.EmployeeEntities;
using UPS.WPF.Model;

namespace UPS.WPF.ViewModel
{
    public class MetaMapper
    {
        public static MetaModel entityToModel(Meta meta)
        {
            var metaModel = new MetaModel()
            {
                CurrentPage = meta.currentPage,
                PageCount = meta.pageCount,
                TotalCount = meta.totalCount,
            };
            return metaModel;

        }
    }
}
