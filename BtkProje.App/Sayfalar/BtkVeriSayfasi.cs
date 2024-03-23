using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkProje.App.Sayfalar
{
    public interface IBtkVeriSayfasi
    {
        void GitOnceki();
        void GitSonraki();
        void GitIlk();
        void GitSon();

        void Sil();
    }
}
