using Raylib_cs;
using System.ComponentModel.Design;
using System.Numerics;


Raylib.InitWindow(1000, 800, "Hello");
Raylib.SetTargetFPS(60);



Vtorn[] Vts;
Vhäst[] Vhs;
Vknäkt[] Vkns;
Vbonde[] Vbs;

Storn[] Sts;
Shäst[] Shs;
Sknäkt[] Skns;
Sbonde[] Sbs;

 Vts = new Vtorn[2];
Vkns = new Vknäkt[2]; 
 Vhs = new Vhäst[2];  
 Vbs = new Vbonde[8];

 Sts = new Storn[2];
 Skns = new Sknäkt[2];
 Shs = new Shäst[2];
 Sbs = new Sbonde[8];

Skung Skung = new Skung(){x=325 , y=20 };                       // S står för svarta pjäser. t.ex Skung står för svart kung.
Sdrottning Sdrottning = new Sdrottning(){x=425 , y=20};
Sts[0] = new Storn() {x=25 , y=20};
Sts[1] = new Storn() {x=725 , y=20};

Shs[0] = new Shäst() {x=125 , y=20};
Shs[1] = new Shäst() {x=625 , y=20};

Skns[0] = new Sknäkt() {x=225 , y=20};
Skns[1] = new Sknäkt() {x=525 , y=20};

int BondeX=25;
for (int r = 0; r < 8; r++){
     Sbs[r] = new Sbonde(){x=BondeX , y=120}; 
     BondeX+=100;}

Vkung Vkung= new Vkung(){ position= new(325,720) };          // V står för vita pjäser. t.ex Vkung står för vit kung.
Vdrottning Vdrottning = new Vdrottning(){ position=new(425,720)}; 

Vkns[0] = new Vknäkt() { position = new(225,720)};             //Vkns = (V)Vit (kn)Knäkt (s)flera/array av
Vkns[1] = new Vknäkt() {  position=new(520,720)};

Vhs[0] = new Vhäst() {position=new(125,720)};
Vhs[1] = new Vhäst() {position=new(625,720)};

Vts[0] = new Vtorn() {position=new(25,720)};
Vts[1] = new Vtorn() {position=new(725,720)};




BondeX=25;
for (int r = 0; r < 8; r++){
     Vbs[r] = new Vbonde() { };
  Vbs[r].position.X=BondeX;
  Vbs[r].position.Y=625;
  BondeX += 100;}

//-----------------------------------------------------------------------------------------------------------

bool startText= true;
bool pjäs1Selected=false;
Vector2 valdpjäs1 = new(0,0);
Vector2 valdpjäs2 = new(0,0);
int valdpjäs1numer =0;
int valdpjäs2numer=0;
 int valdruta1=0;

 while (!Raylib.WindowShouldClose())
{
  if (Raylib.IsKeyPressed(KeyboardKey.R)) //resetknapp som sätter alla variablar till noll och pjäser til startpositionen
  {
     Vkung.position= new (325,720); ;          // V står för vita pjäser. t.ex Vkung står för vit kung.
 Vdrottning.position=new(425,720); 

Vkns[0].position = new(225,720);             //Vkns = (V)Vit (kn)Knäkt (s)flera/array av
Vkns[1].position=new(520,720);

Vhs[0].position=new(125,720);
Vhs[1].position=new(625,720);

Vts[0].position=new(25,720);
Vts[1].position=new(725,720);

 startText= true;
 pjäs1Selected=false;
 valdpjäs1 = new(0,0);
 valdpjäs2 = new(0,0);
 valdpjäs1numer =0;
 valdpjäs2numer=0;
  valdruta1=0;
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

  int[] rutaYPosition ={/*rad 8*/0  ,0  ,0  ,0  ,0  ,0  ,0  ,0  ,
                        /*rad 7*/100,100,100,100,100,100,100,100,
                        /*rad 6*/200,200,200,200,200,200,200,200,
                        /*rad 5*/300,300,300,300,300,300,300,300,
                        /*rad 4*/400,400,400,400,400,400,400,400,
                        /*rad 3*/500,500,500,500,500,500,500,500,
                        /*rad 2*/600,600,600,600,600,600,600,600,
                        /*rad 1*/700,700,700,700,700,700,700,700, };

List<Vector2> ruta=new(){};
Raylib.BeginDrawing();

 

 Raylib.DrawRectangle(800, 0, 200, 800, Color.White); //rectangeln för sidobrädet där alla tagna pjäser hamnar
for (int vilkenRuta = 0; vilkenRuta < rutaXPosition.Length; vilkenRuta++)
{             /* % betyder modulo. ifall resten är 0 så är talet jämt och ifall resten 1 så är talet ojämt*/
  if ((vilkenRuta%2==0 && rutaYPosition[vilkenRuta]%200==0)||(vilkenRuta%2==1 && rutaYPosition[vilkenRuta]%200==100)){  
  Raylib.DrawRectangle(rutaXPosition[vilkenRuta],rutaYPosition[vilkenRuta],100,100, Color.Black);
  ruta.Add(new(rutaXPosition[vilkenRuta],rutaYPosition[vilkenRuta]));
  }
  else{ 
  Raylib.DrawRectangle(rutaXPosition[vilkenRuta],rutaYPosition[vilkenRuta],100,100, Color.Green);
  ruta.Add(new(rutaXPosition[vilkenRuta],rutaYPosition[vilkenRuta]));
  }
}

if (Raylib.IsMouseButtonDown(MouseButton.Left)) {    startText=false;  }
if (startText){  Raylib.DrawText("Tyck på en pjäs för \n\n\n\natt se den (normala)\n\n\n\n gångstilen för pjäsen", 100, 275, 50, Raylib_cs.Color.Blue);}

List <Vector2> pjäser= new() { /*Vit kung*/ Vkung.position,
                   /*Vit Drottning*/ Vdrottning.position,
                   /*Vit Knäkt*/ Vkns[0].position, Vkns[1].position,
                   /*Vit Häst*/ Vhs[0].position
                   /*Vit Torn*/ 
                   /*Vit Bonde*/ 
                 };

//-----------------------------------------------------------------------------------------------------------------------------------
for ( int pjäs = 0; pjäs < pjäser.Count; pjäs++)
    {  Vector2  pjäs1 =  pjäser[pjäs];
     //   Console.WriteLine(pjäs1);
      if ((Raylib.GetMouseX() < pjäs1.X + 38 && Raylib.GetMouseX() > pjäs1.X )   //Väljer vilken pjäs som är pjäs1 (vilken man tänker flytta)
      && (Raylib.GetMouseY() < pjäs1.Y + 78 && Raylib.GetMouseY() > pjäs1.Y )
      && Raylib.IsMouseButtonPressed(MouseButton.Left)&&!pjäs1Selected)
      {
         pjäs1Selected=true;
         valdpjäs1=pjäs1;
          valdpjäs1numer=pjäs;
      }
    }
    if (valdpjäs1==Vkung.position)   
    { for (int CircleX = 0; CircleX < 3; CircleX++)
      { for (int CircleY = 0; CircleY < 3; CircleY++)
        { if (!( (CircleX==1) && (CircleY==1) ))
              { Raylib.DrawCircle((int)Vkung.position.X -100+(100*CircleX) ,(int)Vkung.position.Y-100+(100*CircleY),10, Raylib_cs.Color.Blue);}
         }
       }
     }

 if (Raylib.IsMouseButtonPressed(MouseButton.Right)&& pjäs1Selected)
      {
          for (int valdruta = 0; valdruta < ruta.Count; valdruta++)
          {
            
            if ((Raylib.GetMouseX() < ruta[valdruta].X + 100 && Raylib.GetMouseX() > ruta[valdruta].X ) 
             && (Raylib.GetMouseY() < ruta[valdruta].Y + 100 && Raylib.GetMouseY() > ruta[valdruta].Y ))
            {  for ( int pjäs = 0; pjäs < pjäser.Count; pjäs++)  //börjar på ett för 
    {  Vector2  pjäs2 =  pjäser[pjäs];
       
      if ((pjäs2.X < ruta[valdruta].X + 100 && pjäs2.X > ruta[valdruta].X )                    
             && (pjäs2.Y < ruta[valdruta].Y + 100 && pjäs2.Y > ruta[valdruta].Y ))                          
      {                                                                                        
         valdpjäs2=pjäs2;
          valdpjäs2numer=pjäs;
           valdruta1=valdruta;
      }
    } 
              if (valdpjäs1==Vkung.position) { Vkung.position=new(ruta[valdruta].X+25,ruta[valdruta].Y+20);pjäs1Selected=false;
                                                  if (valdpjäs2==Vkung.position) { if (valdpjäs2numer==0){ }  ;
                                                                                   if (valdpjäs2numer==1){Vdrottning.position=Vdrottning.tagen; }  ;
                                                                                   if (valdpjäs2numer==2){ }  ;
                                                                                   if (valdpjäs2numer==3){ }  ;
                                                                                  }
              
                                               }
              if (valdpjäs1==Vdrottning.position) { Vdrottning.position=new(ruta[valdruta].X+25,ruta[valdruta].Y+20);}

               

           }
          }
      }




//---------------------------------------------------------------------------------------------------------------------------------------
      
    
  
 
 
 Skung.display();
 Sdrottning.display();
  
 Skns[0].display();
 Skns[1].display();

  Shs[0].display();
  Shs[1].display(); 
  
  Sts[0].display();
  Sts[1].display();
 
  
  Sbs[0].display();
  Sbs[1].display();
  Sbs[2].display();
  Sbs[3].display();
  Sbs[4].display();
  Sbs[5].display();
  Sbs[6].display();
  Sbs[7].display();
  
  
  
  Vkung.display();
  Vdrottning.display();
  
   Vkns[0].display();
   Vkns[1].display();
  
   Vhs[0].display();
   Vhs[1].display();
  
  Vts[0].display();
  Vts[1].display();
  
  Vbs[0].display();
  Vbs[1].display();
  Vbs[2].display();
  Vbs[3].display();
  Vbs[4].display();
  Vbs[5].display();
  Vbs[6].display();
  Vbs[7].display();


  

Raylib.EndDrawing();

}