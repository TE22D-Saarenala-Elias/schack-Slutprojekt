using System.Numerics;
using Raylib_cs;
// public class vp{
 class Vkung
{
   public Vector2 position;
   public Vector2 tagen= new(825,20);
    Texture2D imgVku = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_kung.png");

    public void display()
    {
                Raylib.DrawTexture(imgVku, (int) position.X,(int) position.Y, Color.White);
    }
    // bool dead;
    // if (dead){
    //     gameover
    //     svart parti vann
    // }

}

class Vdrottning
{
public Vector2 tagen= new(925,20);
 public Vector2 position;
 Texture2D imgVd = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_drottning.png");

    public void display()
    {
               Raylib.DrawTexture(imgVd, (int) position.X, (int) position.Y, Color.White);
    }
}

class Vtorn
{
   public Vector2 position;
    Texture2D imgVt = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_torn.png");

    public void display()
    {
        Raylib.DrawTexture(imgVt, (int) position.X, (int) position.Y, Color.White);

    }
   
}

class Vknäkt
{
    public Vector2 position;
    
    //225
    //720
 Texture2D imgVkn = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_knäkt.png");
    public void display()
    {    
               Raylib.DrawTexture(imgVkn, (int) position.X, (int) position.Y, Color.White); //x är x-kordinaten för knäkten och y är y-kordinaten för knäkten 
    }                           //imgVkn=image Vit Knäkt

}

 public class Vhäst
{
     public Vector2 position;
 Texture2D imgVh = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_häst.png");
      
   public void display() 
    {
        Raylib.DrawTexture(imgVh, (int) position.X, (int) position.Y, Color.White); 
    }
}

class Vbonde
{
   public Vector2 position;
  
Texture2D imgVb = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_bonde.png");
 
   public void display() 
   {
    Raylib.DrawTexture(imgVb, (int) position.X, (int) position.Y, Color.White); 
   }
}
// }
//-----------------------------------------------------------------------------------------------------------------------------------------------------
// public class sp{
public class Skung
{
    public int x=325;
    public int y=20;
    Texture2D imgsku = Raylib.LoadTexture("svart_kung.png");
       
    public void display()
    {
        Raylib.DrawTexture(imgsku, x, y, Color.White);
    }
}

class Sdrottning
{
    public int x;
    public int y;
    Texture2D imgsd = Raylib.LoadTexture("svart_drottning.png");
    public void display()
    {
        Raylib.DrawTexture(imgsd, x, y, Color.White);
    }
}

class Sknäkt
{
    public int x;
    public int y;
    Texture2D imgsku = Raylib.LoadTexture("svart_knäkt.png");
    public void display()
    {
        Raylib.DrawTexture(imgsku, x, y, Color.White);
    }
}

class Shäst
{
    public int x;
    public int y;
    Texture2D imgsh = Raylib.LoadTexture("svart_häst.png");
    public void display()
    {
        Raylib.DrawTexture(imgsh, x, y, Color.White);
    }
   
}

class Storn
{
    public int x;
    public int y;
    Texture2D imgst = Raylib.LoadTexture("svart_torn.png");
    public void display()
    {
        Raylib.DrawTexture(imgst, x, y, Color.White);
    }
   
}

class Sbonde
{
    public int x; 
    public int y;
    Texture2D imgsb = Raylib.LoadTexture("svart_bonde.png");
    public void display() 
    {
         Raylib.DrawTexture(imgsb, x, y, Color.White); 
    }


}
// }