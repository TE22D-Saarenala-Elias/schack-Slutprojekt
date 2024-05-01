using Raylib_cs;
using System.ComponentModel.Design;
using System.Numerics;


Raylib.InitWindow(1000, 800, "                                                 En roligare version av Schack ");
Raylib.SetTargetFPS(540);



Pjäser.VitTorn[] vitTorn;
Pjäser.VitHäst[] vitHäst;
Pjäser.VitKnäkt[] vitKnäkt;
Pjäser.VitBonde[] vitBonde;

Pjäser.SvartTorn[] svartTorn;
Pjäser.SvartHäst[] svartHäst;
Pjäser.SvartKnäkt[] svartKnäkt;
Pjäser.SvartBonde[] svartBonde;
//-----------------------------------------------------------------------------------------------------------------------------------------------------
                                               
                                                   //Arrayer för de olika pjäserna som får olika egenskaper
//                                                   beroende på vilken pjäsklass dom tilldelas.
vitTorn = new Pjäser.VitTorn[2];
vitKnäkt = new Pjäser.VitKnäkt[2];
vitHäst = new Pjäser.VitHäst[2];
vitBonde = new Pjäser.VitBonde[8];             
//                                                  Skapar även hur många av den pjäsen det ska vara 
svartTorn = new Pjäser.SvartTorn[2];//          t.ex att svartHäst bara ska ha 2 platser eftersom
svartKnäkt = new Pjäser.SvartKnäkt[2];//        att det bara ska finnas två svarta hästar på planen.        
svartHäst = new Pjäser.SvartHäst[2];
svartBonde = new Pjäser.SvartBonde[8];
//-----------------------------------------------------------------------------------------------------------------------------------------------------
Pjäser.SvartKung svartKung = new Pjäser.SvartKung() {position = new(325,20) };                       
Pjäser.SvartDrottning svartDrottning = new Pjäser.SvartDrottning() { position = new(425,20) };
svartTorn[0] = new Pjäser.SvartTorn() { position = new(25,20) };
svartTorn[1] = new Pjäser.SvartTorn() { position = new(725,20) };

svartHäst[0] = new Pjäser.SvartHäst() { position = new(125,20) }; //  Sätter alla x och y kordinater för de svarta pjäsernas start positioner.
svartHäst[1] = new Pjäser.SvartHäst() { position = new(625,20) };

svartKnäkt[0] = new Pjäser.SvartKnäkt() { position = new(225,20) };
svartKnäkt[1] = new Pjäser.SvartKnäkt() { position = new(525,20) };

int bondeX = 25;
for (int r = 0; r < 8; r++) // for-loopen skapar alla x-kordinater för de svarta bönderna samtidigt 
{                           // som den lägger in de olika x och y-värderna för de olika bönderna.
  svartBonde[r] = new Pjäser.SvartBonde() { position = new(bondeX, 120) };
  bondeX += 100;
}

Pjäser.VitKung vitKung = new Pjäser.VitKung() { position = new(325, 720) };          
Pjäser.VitDrottning vitDrottning = new Pjäser.VitDrottning() { position = new(425, 720) };

vitKnäkt[0] = new Pjäser.VitKnäkt() { position = new(225, 720) };             
vitKnäkt[1] = new Pjäser.VitKnäkt() { position = new(525, 720) };

vitHäst[0] = new Pjäser.VitHäst() { position = new(125, 720) }; //  Sätter alla x och y kordinater för de svarta pjäsernas start positioner.
vitHäst[1] = new Pjäser.VitHäst() { position = new(625, 720) };

vitTorn[0] = new Pjäser.VitTorn() { position = new(25, 720) };
vitTorn[1] = new Pjäser.VitTorn() { position = new(725, 720) };




bondeX = 25;
for (int r = 0; r < 8; r++) // for-loopen skapar alla x-kordinater för de vita bönderna samtidigt 
{                           // som den lägger in de olika x och y-värderna för de olika bönderna.
  vitBonde[r] = new Pjäser.VitBonde() {position = new(bondeX, 625) };
  bondeX += 100;
}

//-----------------------------------------------------------------------------------------------------------

int Scen = 0;
bool pjäs1Selected = false;
Vector2 valdPjäs1 = new(0, 0);
Vector2 valdPjäs2 = new(0, 0);    // En samling av variablar som används senare men som skapas innan while-loopen
int valdPjäs1Numer = 0;           // för att värderna inte ska nollställas varje gång frame'n/bilden uppdateras.
int valdPjäs2Numer = 0;
int valdRuta1 = 0;

while (!Raylib.WindowShouldClose())
{
  if (Raylib.IsKeyPressed(KeyboardKey.R)) //resetknapp som nollställer alla variablar och flyttar alla pjäser till sina startpositionen.
  {
    vitKung.position = new(325, 720); ;          
    vitDrottning.position = new(425, 720);

    vitKnäkt[0].position = new(225, 720);             
    vitKnäkt[1].position = new(525, 720);

    vitHäst[0].position = new(125, 720);
    vitHäst[1].position = new(625, 720);

    vitTorn[0].position = new(25, 720);
    vitTorn[1].position = new(725, 720);


    svartKung.position = new(325, 20); ;          
    svartDrottning.position = new(425, 20);

    svartKnäkt[0].position = new(225, 20);             
    svartKnäkt[1].position = new(525, 20);

    svartHäst[0].position = new(125, 20);
    svartHäst[1].position = new(625, 20);

    svartTorn[0].position = new(25, 20);
    svartTorn[1].position = new(725, 20);


    Scen = 0;
    pjäs1Selected = false;
    valdPjäs1 = new(0, 0);
    valdPjäs2 = new(0, 0);
    valdPjäs1Numer = 0;
    valdPjäs2Numer = 0;
    valdRuta1 = 0;


  }


  //-------------------------------------------------------------------------------------------------------------------
  //                              RENDERING
  //---------------------------------------------------------------------------------------------------------------------

  int[] rutaXPosition ={/*rad 8*/0,100,200,300,400,500,600,700,
                       /*rad 7*/0,100,200,300,400,500,600,700,
                       /*rad 6*/0,100,200,300,400,500,600,700,
                       /*rad 5*/0,100,200,300,400,500,600,700,
                       /*rad 4*/0,100,200,300,400,500,600,700,
                       /*rad 3*/0,100,200,300,400,500,600,700,
                       /*rad 2*/0,100,200,300,400,500,600,700,
                       /*rad 1*/0,100,200,300,400,500,600,700, };
                                                                      // Två arrayer där den ena står för rutans x-värde medans den andra står för rutans y-värde.
  int[] rutaYPosition ={/*rad 8*/0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,
                        /*rad 7*/100,100,100,100,100,100,100,100,
                        /*rad 6*/200,200,200,200,200,200,200,200,
                        /*rad 5*/300,300,300,300,300,300,300,300,
                        /*rad 4*/400,400,400,400,400,400,400,400,
                        /*rad 3*/500,500,500,500,500,500,500,500,
                        /*rad 2*/600,600,600,600,600,600,600,600,
                        /*rad 1*/700,700,700,700,700,700,700,700, };
List<Vector2> ruta = new() { };
  
  Raylib.BeginDrawing();



  Raylib.DrawRectangle(800, 0, 200, 800, Color.White); //rectangeln för sidobrädet där alla tagna pjäser hamnar

  for (int vilkenRuta = 0; vilkenRuta < rutaXPosition.Length; vilkenRuta++) // for-loopen skapar fyrkanter i ett mönster som bildar ett shack bräde.
  {             /* % betyder modulo. ifall resten är 0 så är talet jämt och ifall resten 1 så är talet ojämt*/
    if ((vilkenRuta % 2 == 0 && rutaYPosition[vilkenRuta] % 200 == 0) || (vilkenRuta % 2 == 1 && rutaYPosition[vilkenRuta] % 200 == 100))
    {
      Raylib.DrawRectangle(rutaXPosition[vilkenRuta], rutaYPosition[vilkenRuta], 100, 100, Color.Black);
      ruta.Add(new(rutaXPosition[vilkenRuta], rutaYPosition[vilkenRuta]));
    }
    else
    {
      Raylib.DrawRectangle(rutaXPosition[vilkenRuta], rutaYPosition[vilkenRuta], 100, 100, Color.Green);
      ruta.Add(new(rutaXPosition[vilkenRuta], rutaYPosition[vilkenRuta]));
    }
  }


  if (Raylib.IsMouseButtonPressed(MouseButton.Left)||Raylib.IsMouseButtonPressed(MouseButton.Right)) { Scen++; } // gör så att scenen byter till nästa text.
  
  if (Scen==0) { Raylib.DrawText("Vänsterklicka på en pjäs (Vita \n\n\n\nKungen) för att se den normala\n\n\n\n gångstilen för pjäsen", 100, 275, 50, Raylib_cs.Color.Blue); }
  if (Scen==1) { Raylib.DrawText("Högerklicka sedan på rutan som\n\n\n\n(bara vita drottningen kan tas)\n\n\n\ndu vill flytta pjäsen till eller\n\n\n\nhögerklicka på den valda pjäsen\n\n\n\nför att avbryta förlyttningen ", 100, 275, 50, Raylib_cs.Color.Blue); }
  
 //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

  List<Vector2> pjäser = new() {               // En lista på alla pjäsers positionenr
                                 /*Vit kung*/ vitKung.position,
                                 /*Vit Drottning*/ vitDrottning.position,
                                 /*Vit Knäkt*/ vitKnäkt[0].position, vitKnäkt[1].position,
                                 /*Vit Häst*/ vitHäst[0].position, vitHäst[1].position,
                                 /*Vit Torn*/ vitTorn[0].position, vitTorn[1].position,
                                 /*Vit Bonde*/ vitBonde[0].position, vitBonde[1].position, vitBonde[2].position, vitBonde[3].position, 
                                               vitBonde[4].position, vitBonde[5].position, vitBonde[6].position, vitBonde[7].position,

                                 /*Svart kung*/ svartKung.position,
                                 /*Vit Drottning*/ svartDrottning.position,
                                 /*Vit Knäkt*/ svartKnäkt[0].position, svartKnäkt[1].position, 
                                 /*Vit Häst*/ svartHäst[0].position, svartHäst[1].position,
                                 /*Vit Torn*/ svartTorn[0].position, svartTorn[1].position,
                                 /*Vit Bonde*/ svartBonde[0].position, svartBonde[1].position, svartBonde[2].position, svartBonde[3].position, 
                                               svartBonde[4].position, svartBonde[5].position, svartBonde[6].position, svartBonde[7].position
                                };


 
  for (int pjäs = 0; pjäs < pjäser.Count; pjäs++)
  {
    Vector2 pjäs1 = pjäser[pjäs];
    //   Console.WriteLine(pjäs1);
    if ((Raylib.GetMouseX() < pjäs1.X + 38 && Raylib.GetMouseX() > pjäs1.X)   //Väljer vilken pjäs som är pjäs1 (vilken man tänker flytta)
    && (Raylib.GetMouseY() < pjäs1.Y + 78 && Raylib.GetMouseY() > pjäs1.Y)
    && Raylib.IsMouseButtonPressed(MouseButton.Left) && !pjäs1Selected)
    {
      pjäs1Selected = true;
      valdPjäs1 = pjäs1;
      valdPjäs1Numer = pjäs;
    }
  }


  if (Raylib.IsMouseButtonPressed(MouseButton.Right) && pjäs1Selected)
  {
    for (int valdruta = 0; valdruta < ruta.Count; valdruta++)
    {

      if ((Raylib.GetMouseX() < ruta[valdruta].X + 100 && Raylib.GetMouseX() > ruta[valdruta].X)
       && (Raylib.GetMouseY() < ruta[valdruta].Y + 100 && Raylib.GetMouseY() > ruta[valdruta].Y))
      {
        for (int pjäs = 0; pjäs < pjäser.Count; pjäs++)  //börjar på ett för 
        {
          if (pjäs==valdPjäs1Numer) {pjäs++;}
          Vector2 pjäs2 = pjäser[pjäs];

          if ((pjäs2.X < ruta[valdruta].X + 100 && pjäs2.X > ruta[valdruta].X)
                 && (pjäs2.Y < ruta[valdruta].Y + 100 && pjäs2.Y > ruta[valdruta].Y))
          {
            valdPjäs2 = pjäs2;
            valdPjäs2Numer = pjäs;
            valdRuta1 = valdruta;
          }
        }
            if (valdPjäs1 == vitKung.position)
            {
               
              if (((vitKung.position.X -100== ruta[valdruta].X+25)&&(vitKung.position.Y -100== ruta[valdruta].Y+20)) || 
                  ((vitKung.position.X == ruta[valdruta].X+25)&&(vitKung.position.Y -100== ruta[valdruta].Y+20)) || 
                  ((vitKung.position.X + 100== ruta[valdruta].X+25)&&(vitKung.position.Y -100== ruta[valdruta].Y+20)) || 

                  ((vitKung.position.X - 100== ruta[valdruta].X+25)&&(vitKung.position.Y== ruta[valdruta].Y+20)) || 
                  ((vitKung.position.X + 100== ruta[valdruta].X+25)&&(vitKung.position.Y== ruta[valdruta].Y+20)) || 

                  ((vitKung.position.X - 100== ruta[valdruta].X+25)&&(vitKung.position.Y +100== ruta[valdruta].Y+20)) || 
                  ((vitKung.position.X == ruta[valdruta].X+25)&&(vitKung.position.Y +100== ruta[valdruta].Y+20)) || 
                  ((vitKung.position.X + 100 == ruta[valdruta].X+25)&&(vitKung.position.Y +100== ruta[valdruta].Y+20)) )
              {
                
              
                vitKung.position = new(ruta[valdruta].X + 25, ruta[valdruta].Y + 20);
                if (valdPjäs2 == vitKung.position)
                {
                  if (valdPjäs2Numer == 0) { vitKung.position=vitKung.tagen;}
                  if (valdPjäs2Numer == 1) { vitDrottning.position = vitDrottning.tagen; }
                  if (valdPjäs2Numer == 2) { }
                  if (valdPjäs2Numer == 3) { }
                }
              } else{  vitKung.felMeddelande=true;  }
            }                        
            
            if (valdPjäs1 == vitDrottning.position) { vitDrottning.position = new(ruta[valdruta].X + 25, ruta[valdruta].Y + 20); }



      }
    }
     pjäs1Selected = false; valdPjäs1=new(0,0);
  }




  //---------------------------------------------------------------------------------------------------------------------------------------





  svartKung.Rendera();
  svartDrottning.Rendera();

  svartKnäkt[0].Rendera();
  svartKnäkt[1].Rendera();

  svartHäst[0].Rendera();
  svartHäst[1].Rendera();

  svartTorn[0].Rendera();
  svartTorn[1].Rendera();


  svartBonde[0].Rendera();
  svartBonde[1].Rendera();
  svartBonde[2].Rendera();
  svartBonde[3].Rendera();
  svartBonde[4].Rendera();
  svartBonde[5].Rendera();
  svartBonde[6].Rendera();
  svartBonde[7].Rendera();



  vitKung.Rendera();
  vitDrottning.Rendera();

  vitKnäkt[0].Rendera();
  vitKnäkt[1].Rendera();

  vitHäst[0].Rendera();
  vitHäst[1].Rendera();

  vitTorn[0].Rendera();
  vitTorn[1].Rendera();

  vitBonde[0].Rendera();
  vitBonde[1].Rendera();
  vitBonde[2].Rendera();
  vitBonde[3].Rendera();
  vitBonde[4].Rendera();
  vitBonde[5].Rendera();
  vitBonde[6].Rendera();
  vitBonde[7].Rendera();


 
    
  if (vitKung.felMeddelande==true)
  {
    Raylib.DrawText("Kungen är gammal och kan bara \n\n\n\n gå ett steg i taget. Vänsterklicka \n\n\n\n på kungen och sen högerklicka\n\n\n\n"+
                    "på en av cirklarna för att\n\n\n\n förflytta kungen.", 100, 275, 50, Raylib_cs.Color.Blue);
    if (Raylib.IsMouseButtonPressed(MouseButton.Left))
    {
      vitKung.felMeddelande=false;
    }
   
  }

  if (valdPjäs1 == vitKung.position) { vitKung.GångStil(); }


  Raylib.EndDrawing();

}
