int count = 0;
int ferstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;
int distance = 10000;

while(distance > 10) {
if(friend == 1) {
time = distance / (ferstFriendSpeed + dogSpeed);
}
else
{
   time = distance / (secondFriendSpeed + dogSpeed); 
}

distance = distance - (ferstFriendSpeed + secondFriendSpeed) * time;

count = count + 1;
}

Console.WriteLine("Собака пробежит " + count  + " раз");


