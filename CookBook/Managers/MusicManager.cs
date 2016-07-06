using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookBook.Managers
{
    public static class MusicManager
    {
        public static void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }
    }
}
