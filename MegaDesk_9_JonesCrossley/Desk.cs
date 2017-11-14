using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace MegaDesk_9_JonesCrossley
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawerCount { get; set; }
        public DesktopMaterial Surface { get; set; }

        public enum DesktopMaterial
        {
            Laminate = 100, Oak = 200, Rosewood = 300, Veneer = 125, Pine = 50
        };

        public static List<SelectListItem> DesktopMaterialSelect()
        {
            var list = new List<SelectListItem>();
            foreach (int i in Enum.GetValues(typeof(DesktopMaterial)))
            {
                list.Add(new SelectListItem { Text = Enum.GetName(typeof(DesktopMaterial), i), Value = i.ToString() });
            }
            return list;
        }

        public int GetSurfaceArea()
        {
            int area;
            area = Width * Depth;
            return area;
        }
    }
}
