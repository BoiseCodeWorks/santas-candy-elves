using System;
using System.Collections.Generic;
using elves.Models;

namespace elves
{
  class Program
  {
    static void Main(string[] args)
    {
      Elf jingle = new Elf("Jingle", 6, 10, 18);
      Elf dash = new Elf("Dash", 7, 10, 1);
      Elf bubbles = new Elf("Bubbles", 8, 12, 10);
      Elf sparkle = new Elf("Sparkle", 10, 11, 17);
      Elf cookie = new Elf("Cookie", 11, 16, 4);
      Elf frosty = new Elf("Frosty", 11, 14, 8);
      Elf twinkle = new Elf("Twinkle", 13, 14, 22);
      Elf jangle = new Elf("Jangle", 13, 18, 15);
      Elf spunky = new Elf("Spunky", 15, 22, 1);
      Elf sunny = new Elf("Sunny", 14, 20, 12);
      Elf happy = new Elf("Happy", 16, 19, 13);
      List<Elf> elves = new List<Elf>() { jingle, dash, bubbles, sparkle, cookie, frosty, twinkle, jangle, spunky, sunny, happy };
      
      // YOUR SOLUTION HERE

    }
  }
}
