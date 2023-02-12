//  start main
int userChoice = GetUserChoice();   // priming read
// pre-test loop
while(userChoice!=3) {              // condition check
    RouteEm(userChoice);
    userChoice = GetUserChoice();   // update read
}

//  end main
static int GetUserChoice(){
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userChoice) {
    if(userChoice == "1" || userChoice == "2" || userChoice== "3"){
        return true;
    }
    else return false;
}

static void RouteEm(int menuChoice) {
    if(menuChoice==1) {
        int count = GetRandomCount();
        WelcomeFullPyramid(count);
        int length = Getlength();
        int space = SpaceCalculation(count);
        DisplayFullPyramind(count, space, length);
    }
    else if (menuChoice==2){
        int count = GetRandomCount();
        WelcomePartialPyramid(count);
        DisplayPartialTriangle(count);
    }
    else if(menuChoice!=3) {
        SayInvalid();
    }
}

//Menu option 1 display full triangle
static void WelcomeFullPyramid(int count) {
    System.Console.WriteLine($"System is generating a random number and will display a full pyramid \nYour randomly generated number is: {count}");
    PauseAction();
}

static int GetRandomCount(){
    Random rnd = new Random();
    int count = rnd.Next(3, 10);
    return count;
}

static int SpaceCalculation(int count){
    int space = 0;
    space = count - 1;
    return space;
}

static int Getlength(){
    int length = 1;
    return length;
}

static void DisplayFullPyramind(int count, int space, int length){
    for(int i=1; i<=count; i++){
        for(int r=1; r<=space; r++){
            Console.Write(" ");
        }
        for(int s=1; s<=length; s++){
            Console.Write("0");
        }  
        space--;
        length = length + 2;
        Console.WriteLine();
    }
    PauseAction();
}   

//Menu option 2 display partial triangle

//random number method is used here

static void WelcomePartialPyramid(int count){
    System.Console.WriteLine($"System is generating a random number and will display a full pyramid \nYour randomly generated number is: {count}");
    PauseAction();
}

static void DisplayPartialTriangle(int count) {
Random random = new Random();

   for (int i = 1; i <= count; i++){
        for (int j = count - i; j >= 1; j--)
            {
            Console.Write(" ");
            }
        for (int j = 1; j <= i; j++){             
            if (random.Next(6) < 4){
            Console.Write("O ");
            }
           else {
            Console.Write("  ");
            }
        }
        Console.WriteLine();         
    }
    PauseAction();
}



//Random methods
static void SayInvalid() {
    System.Console.WriteLine("Your choice is invalid, please try again");
        PauseAction();
}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

