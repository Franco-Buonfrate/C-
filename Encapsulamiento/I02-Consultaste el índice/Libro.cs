using System;
using System.Collections.Generic;

namespace I02_Consultaste_el_índice
{
    public class Libro
    {
        private List<string> paginas;
        public Libro()
        {
            this.paginas = new List<string>();
        }
        public string this[int index]
        {
            get
            {
                if (this.paginas.Count > index)
                    return paginas[index];
                else
                    return string.Empty;
            }
            set
            {
                if (index > this.paginas.Count)
                    this.paginas.Add(value);
            }
        }
    }
}
