using OpenTK.Windowing.Common.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman2
{
    public class Map
    {
        private Object[] map;
        private int xLenght;
        private int yLenght;

        public XLength

        public Object[] MapArray
        {
            get { return map; }
        }

        private void LoadMap(string path)
        {
            FileStream reader = new FileStream(path, FileMode.Open);

            map = new Object[reader.Length];

            for (int i = 0; i < reader.Length; i++)
            {
                map[i] = new Object();

                byte[] buffer = new byte[3];
                reader.Read(buffer, i * 3, 3);
                map[i].ID = (buffer[0] + 1) * 1000000 + (buffer[1] + 1) * 1000 + (buffer[0] + 1);
            }
        }
    }
}
