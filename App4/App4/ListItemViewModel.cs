using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace App4
{
    class ListItemViewModel
    {
        private List<List> ListItems_;
        public List<List> ListItems
        {
            get { return ListItems_; }
            set { ListItems_ = value;  }
        }
    }
}
