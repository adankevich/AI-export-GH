 private readonly Random rand = new Random();
 
   private Color RandomColour()
  {
    return Color.FromArgb(this.rand.Next(256), this.rand.Next(256), this.rand.Next(256));
  }
