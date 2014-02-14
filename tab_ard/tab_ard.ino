//Tabulatron Arduino Code
//Will signal via Serial whenever a button is pressed
// Circuit is pretty simply
// - Pushbutton on A0
// - Pushbutton on A1
// - Pushbutton on A2
// - Pushbutton on A3
// - LED on 13
// Many, many thanks to Adafruit industries where I blatantly lifted this code
// http://www.adafruit.com/blog/2009/10/20/example-code-for-multi-button-checker-with-debouncing/
// Buy something from there please

//Globals variables
//  Hash marked lines are not comments in the Arduino IDE as is common
//  with other languages, more details: http://arduino.cc/en/Reference/Define

#define DEBOUNCE 50
byte buttons[] = {14, 15,16, 17}; // the analog 0-4 pins are also known as 14-17
#define NUMBUTTONS sizeof(buttons)
byte pressed[NUMBUTTONS], justpressed[NUMBUTTONS], justreleased[NUMBUTTONS];
int led = 13;

void setup() {
  byte i;
  
  Serial.begin(9600);
  pinMode(13, OUTPUT);
 
  // Make input & enable pull-up resistors on switch pins
  for (i=0; i< NUMBUTTONS; i++) {
    pinMode(buttons[i], INPUT);
    digitalWrite(buttons[i], HIGH);
  }
  start_led();

}

//LED blink sequence for when device starts up.
void start_led()
{
  digitalWrite(led, HIGH);
  delay(1000);
  digitalWrite(led, LOW);
  delay(1000); 
}

//LED blink sequence for after a button is pressed
//gives nice feeling that the machine is paying attention
void flick_led()
{
  digitalWrite(led,HIGH);
  delay(250);
  digitalWrite(led,LOW);
  delay(250);
  digitalWrite(led,HIGH);
  delay(250);
  digitalWrite(led,LOW);
  delay(250);
  digitalWrite(led,HIGH);
  delay(250);
  digitalWrite(led,LOW);
  delay(250);
}

//This function does the heavy lifting of checking for button presses
//and changing the values of the byte array to reflect button
//states
void check_switches()
{
  static byte previousstate[NUMBUTTONS];
  static byte currentstate[NUMBUTTONS];
  static long lasttime;
  byte index;

  if (millis() < lasttime) {
     // we wrapped around, lets just try again
     lasttime = millis();
  }
  
  if ((lasttime + DEBOUNCE) > millis()) {
    // not enough time has passed to debounce
    return; 
  }
  // ok we have waited DEBOUNCE milliseconds, lets reset the timer
  lasttime = millis();
  
  for (index = 0; index < NUMBUTTONS; index++) {
    justpressed[index] = 0;       // when we start, we clear out the "just" indicators
    justreleased[index] = 0;
     
    currentstate[index] = digitalRead(buttons[index]);   // read the button
    
    if (currentstate[index] == previousstate[index]) {
      if ((pressed[index] == LOW) && (currentstate[index] == LOW)) {
          // just pressed
          justpressed[index] = 1;
      }
      else if ((pressed[index] == HIGH) && (currentstate[index] == HIGH)) {
          // just released
          justreleased[index] = 1;
      }
      pressed[index] = !currentstate[index];  // remember, digital HIGH means NOT pressed
    }
    previousstate[index] = currentstate[index];   // keep a running tally of the buttons
  }
}

void loop() {
  check_switches();
  for (byte i = 0; i < NUMBUTTONS; i++) {
    if (justpressed[i]) {
      Serial.print(i, DEC); //Print the button number to the serial port so that the processing app can listen for it.
      //Serial.println();
      Serial.flush();  //Always flush when you're done.
      flick_led(); //An immediate couple of blinks of the LED makes the user feel like it has done something
    }
    //Serial.print(NUMBUTTONS + 1,DEC); //Keep Alive signal will be int 5?  Why? my buttons are already going 0 - 4

  }
}
