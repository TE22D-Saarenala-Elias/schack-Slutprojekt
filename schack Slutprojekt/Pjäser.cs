using System.Numerics;
using Raylib_cs;
public class Pjäser{
 public class VitKung
{
    public bool felMeddelande=false;
    public Vector2 position;
    public Vector2 tagen= new(825,20);
    Texture2D pjäsBild = Raylib.LoadTexture("vit_kung.png");

    public void Rendera()       //  Rendera är en metod som skapar pjäsen genom att rita ut png:n för pjäsen som.
    {                           //  I det här fallet så är det "vit_kung.png" som ritas ut och används för att styra och flytta pjäsen "VitKung". 
        Raylib.DrawTexture(pjäsBild, (int) position.X,(int) position.Y, Color.White); 
    }                           //  position.X är x-kordinaten för vita kungen och position.Y är y-kordinaten för vita kungen.

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public void GångStil(){                        //  Metoden GångStil skapar cirklar på de rutor som pjäsen kan gå till enligt de traditionella shack-reglerna.
                                                   //  Eftersom att den hära GångStil:en är innanför klassen VitKung så är den gjord så att den skapar en 3x3 grid
     for (int cirkelX = 0; cirkelX < 3; cirkelX++) //  runt om pjäsen med hjälp av två for loopar. 
    {
      for (int cirkelY = 0; cirkelY < 3; cirkelY++)
      {
        if (position.X==25&&cirkelX==0)  {  cirkelX=1;  }   // De fyra fyra if-satserna kollar ifall kungen är vid en kant-ruta eller ett 
        else if (position.X==725&&cirkelX==2)  {  break;  } // hörn och filtrerar bort de cirklarna som skulle ha skapats utanför brädet.
        if (position.Y==20&&cirkelY==0)  {  cirkelY=1;  }
        else if (position.Y==720&&cirkelY==2)  {  break;  }

        if (!((cirkelX == 1) && (cirkelY == 1))) // if-satsen ser till att skapa alla cirklar inom griden förutom på den platsen som pjäsen står på
        {                                        // samt att dra en linjer från pjäsen till cirklarna.
          Raylib.DrawCircle((int)position.X - 100 + (100 * cirkelX) + 25, (int)position.Y - 100 + (100 * cirkelY) + 30, 10, Raylib_cs.Color.Blue);
          Raylib.DrawLine((int)position.X + 19, (int)position.Y + 30, (int)position.X - 100 + (100 * cirkelX) + 25, (int)position.Y - 100 + (100 * cirkelY) + 30, Raylib_cs.Color.Blue);
        }
      }
    }
  
 }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

}

public class VitDrottning
{
public Vector2 tagen= new(925,20);
 public Vector2 position;
 Texture2D pjäsBild = Raylib.LoadTexture("vit_drottning.png");

    public void Rendera()
    {
               Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White);
    }
}

public class VitTorn
{
    public Vector2 position;
    Texture2D pjäsBild = Raylib.LoadTexture("vit_torn.png");

    public void Rendera() 
    {
        Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White);
    }
   
}

public class VitKnäkt
{
    public Vector2 position;
    Texture2D pjäsBild = Raylib.LoadTexture("vit_knäkt.png");
    
    public void Rendera()
    {    
               Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White); 
    }                           

}

 public class VitHäst
{
    public Vector2 position;
    Texture2D pjäsBild = Raylib.LoadTexture("vit_häst.png");
      
    public void Rendera() 
    {
        Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White); 
    }
}

public class VitBonde
{
   public Vector2 position;
   Texture2D pjäsBild = Raylib.LoadTexture("vit_bonde.png");
 
   public void Rendera() 
   {
    Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White); 
   }
}

public class SvartKung
{
    public Vector2 position;
    Texture2D pjäsBild = Raylib.LoadTexture("svart_kung.png");
       
    public void Rendera()
    {
        Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White);
    }
}

public class SvartDrottning
{
    public Vector2 position;
    Texture2D pjäsBild = Raylib.LoadTexture("svart_drottning.png");
    public void Rendera()
    {
        Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White);
    }
}

public class SvartKnäkt
{
    public Vector2 position;
    Texture2D pjäsBild = Raylib.LoadTexture("svart_knäkt.png");
    public void Rendera()
    {
        Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White);
    }
}

public class SvartHäst
{
    public Vector2 position;
    Texture2D pjäsBild = Raylib.LoadTexture("svart_häst.png");
    public void Rendera()
    {
        Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White);
    }
   
}

public class SvartTorn
{
    public Vector2 position;
    Texture2D pjäsBild = Raylib.LoadTexture("svart_torn.png");
    public void Rendera()
    {
        Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White);
    }
   
}

public class SvartBonde
{
    public Vector2 position;
    Texture2D pjäsBild = Raylib.LoadTexture("svart_bonde.png");
    public void Rendera() 
    {
         Raylib.DrawTexture(pjäsBild, (int) position.X, (int) position.Y, Color.White); 
    }


}
}