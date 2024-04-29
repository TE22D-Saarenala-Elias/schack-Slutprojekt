using System.Numerics;
using Raylib_cs;
public class Allapjäser{
 public class Vkung
{
   public Vector2 position;
   public Vector2 tagen= new(825,20);
    Texture2D imgVku = Raylib.LoadTexture("vit_kung.png");

    public void display()
    {
                Raylib.DrawTexture(imgVku, (int) position.X,(int) position.Y, Color.White);
    }
    // bool dead;
    // if (dead){
    //     gameover
    //     svart parti vann
    // }

    public void gångStil(){
 for (int CircleX = 0; CircleX < 3; CircleX++)
    {
      for (int CircleY = 0; CircleY < 3; CircleY++)
      {
        if (position.X == 25 && CircleX == 0) { CircleX = 1; }

        if (position.Y == 20 && CircleY == 0) { CircleY = 1; }
        if (!((CircleX == 1) && (CircleY == 1)))
        {
          Raylib.DrawCircle((int)position.X - 100 + (100 * CircleX) + 25, (int)position.Y - 100 + (100 * CircleY) + 30, 10, Raylib_cs.Color.Blue);
          Raylib.DrawLine((int)position.X + 19, (int)position.Y + 30, (int)position.X - 100 + (100 * CircleX) + 25, (int)position.Y - 100 + (100 * CircleY) + 30, Raylib_cs.Color.Blue);
        }
        if (position.Y == 720 && CircleY == 1) { CircleY = 2; }
        

      }if (position.X==725 && CircleX == 1)  {CircleX=2;  }
    }
  
 }

}

public class Vdrottning
{
public Vector2 tagen= new(925,20);
 public Vector2 position;
 Texture2D imgVd = Raylib.LoadTexture("vit_drottning.png");

    public void display()
    {
               Raylib.DrawTexture(imgVd, (int) position.X, (int) position.Y, Color.White);
    }
}

public class Vtorn
{
   public Vector2 position;
    Texture2D imgVt = Raylib.LoadTexture("vit_torn.png");

    public void display()
    {
        Raylib.DrawTexture(imgVt, (int) position.X, (int) position.Y, Color.White);

    }
   
}

public class Vknäkt
{
    public Vector2 position;
    
 Texture2D imgVkn = Raylib.LoadTexture("vit_knäkt.png");
    public void display()
    {    
               Raylib.DrawTexture(imgVkn, (int) position.X, (int) position.Y, Color.White); //position.x är x-kordinaten för knäkten och position.y är y-kordinaten för knäkten 
    }                           //imgVkn=image Vit Knäkt

}

 public class Vhäst
{
     public Vector2 position;
 Texture2D imgVh = Raylib.LoadTexture("vit_häst.png");
      
   public void display() 
    {
        Raylib.DrawTexture(imgVh, (int) position.X, (int) position.Y, Color.White); 
    }
}

public class Vbonde
{
   public Vector2 position;
  
Texture2D img = Raylib.LoadTexture("vit_bonde.png");
 
   public void display() 
   {
    Raylib.DrawTexture(img, (int) position.X, (int) position.Y, Color.White); 
   }
}

public class Skung
{
    public Vector2 position;
    Texture2D img = Raylib.LoadTexture("svart_kung.png");
       
    public void display()
    {
        Raylib.DrawTexture(img, (int) position.X, (int) position.Y, Color.White);
    }
}

public class Sdrottning
{
    public Vector2 position;
    Texture2D img = Raylib.LoadTexture("svart_drottning.png");
    public void display()
    {
        Raylib.DrawTexture(img, (int) position.X, (int) position.Y, Color.White);
    }
}

public class Sknäkt
{
    public Vector2 position;
    Texture2D img = Raylib.LoadTexture("svart_knäkt.png");
    public void display()
    {
        Raylib.DrawTexture(img, (int) position.X, (int) position.Y, Color.White);
    }
}

public class Shäst
{
    public Vector2 position;
    Texture2D img = Raylib.LoadTexture("svart_häst.png");
    public void display()
    {
        Raylib.DrawTexture(img, (int) position.X, (int) position.Y, Color.White);
    }
   
}

public class Storn
{
    public Vector2 position;
    Texture2D img = Raylib.LoadTexture("svart_torn.png");
    public void display()
    {
        Raylib.DrawTexture(img, (int) position.X, (int) position.Y, Color.White);
    }
   
}

public class Sbonde
{
    public Vector2 position;
    public Texture2D img = Raylib.LoadTexture("svart_bonde.png");
    public void display() 
    {
         Raylib.DrawTexture(img, (int) position.X, (int) position.Y, Color.White); 
    }


}
}