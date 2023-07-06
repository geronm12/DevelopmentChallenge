namespace DevelopmentChallenge.Data
{
    using System;
    using System.Collections.Generic;
    public abstract class Idioma
    {
        public virtual Dictionary<Keys, String> Traducciones { get; set; }

        public Idioma()
        {
        }
        public virtual String Traducir(Keys key)
        {
            String traduccion = "";
            Traducciones.TryGetValue(key, out traduccion);

            return traduccion;
        }
    }

}
