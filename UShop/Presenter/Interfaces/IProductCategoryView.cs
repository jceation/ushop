﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
    public interface IProductCategoryView
    {
        void loadProductCategories(List<ProductCategory> listObj);

    }
}
