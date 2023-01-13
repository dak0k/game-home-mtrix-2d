string[,] rooms = new string[4, 3]
{
    { "Спальня_1 "   , "\t Коридор " , "\t Кухня       "   },
    { "Спальня_2 "   , "\t Коридор " , "\t Холодильник "   },
    { "Детская   "   , "\t Коридор " , "\t Столовая    "   },
    { "Прачечная "   , "\t Ванная  " , "\t Туалет      "   },
};



int currentY = 0;
int currentX = 0;


const int Y = 3;//строки
const int X = 2;// столбцы
currentY = Y;
currentX = X;



SetPosition(currentY, currentX);


ShowRooms();

while (true)
{
     Console.Write("Command: ");
string inputCmd = Console.ReadLine();



if (inputCmd == "up"  )
{

  if(currentY >= 1){
     SetPosition(currentY -1, currentX);
     ShowRooms();
  }else{
       elseF();  

  }
}
else if(inputCmd == "down"){

   if(currentY <= 1){
   SetPosition(currentY + 1 , currentX );
    ShowRooms(); 
 
   }else{
              elseF();  
    
   }
}
else if(inputCmd == "right"){

   if(currentX <=1){
       SetPosition(currentY, currentX + 1);
    ShowRooms();
   }else{
          elseF();  
   }

}
else if(inputCmd == "left"){
if(currentX >= 1){
        SetPosition(currentY, currentX - 1);
    ShowRooms();
}
else{
     elseF();  
   }
}
}
void elseF(){
  SetPosition(currentY  , currentX );
    ShowRooms();
}
void ShowRooms()
{
Console.Clear();
int rows = rooms.GetUpperBound(0) + 1; // строки
int cols = rooms.Length / rows; // столбцы

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(rooms[i, j] + " ");
    }

    Console.WriteLine();
} 

}
void SetPosition(int yPosition, int xPosition){
    currentY = yPosition;
    currentX = xPosition;
    rooms = new string[4, 3]
    {
        { "Спальня_1 "   , "\t Коридор " , "\t Кухня       "   },
        { "Спальня_2 "   , "\t Коридор " , "\t Холодильник "   },
        { "Детская   "   , "\t Коридор " , "\t Столовая    "   },
        { "Прачечная "   , "\t Ванная  " , "\t Туалет      "   },
    };
    rooms[currentY, currentX] += "(You)" ;
}
