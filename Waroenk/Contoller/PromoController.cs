using System;
using System.Collections.Generic;
using System.Text;
using Waroenk.Model;

namespace Waroenk.Contoller
{
    class PromoController
    {
        private List<Diskon> diskon;

        public PromoController()
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
