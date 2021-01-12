using System;
using System.Collections.Generic;
using System.Text;
using Waroenk.Model;

namespace Waroenk.Controller
{
    class VoucherController
    {
        public List<Diskon> diskon;

        public VoucherController()
        {
            diskon = new List<Diskon>();
        }

        public void addPromo(Diskon diskon)
        {
            this.diskon.Add(diskon);
        }

        public List<Diskon> getDiskon()
        {
            return this.diskon;
        }
    }
}