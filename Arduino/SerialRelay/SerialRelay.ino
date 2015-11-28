// ***********************************************************************
// Assembly         : Serial Relay Controller
// Author           : Andrew Kitchens
// Modified         : 11-24-2015
//
// Last Modified By : Andrew Kitchens
// Last Modified On : 11-24-2015
// ***********************************************************************
// <copyright file="SerialRelay.ino" company="AJK Services">
//     Copyright AJK Services © 2015
// </copyright>
// <summary>Controls Arduino pins based on serial commands from PC desktop application.</summary>
// <remarks>Baesed on project by Brian Johnston W8TFI.</remarks>

// ***********************************************************************

#define RELAY_1 2
#define RELAY_2 3
#define RELAY_3 4
#define RELAY_4 5
#define RELAY_5 6
#define RELAY_6 7
#define RELAY_7 8
#define RELAY_8 9

#define ACTIVE LOW

void setup() {
  // Initialize pins. Set all pins inactive.
  for (int thisPin = 2; thisPin < 14; thisPin++) {
    pinMode(thisPin, OUTPUT);
    digitalWrite(thisPin, !ACTIVE);
  }

  // Initialize serial communication.
  Serial.begin(9600);   
  Serial.write("SerialRelay V1.0");
  Serial.write("Ready ...");	
}

void TurnOffPins() {
  for (int thisPin = 2; thisPin < 14; thisPin++) {
    digitalWrite(thisPin, !ACTIVE);
  }
}

void loop() {
  // read the sensor:
  if (Serial.available() > 0) {
    int inByte = Serial.read();
      
    switch (inByte) { 
      case 'a':  
        TurnOffPins();
        digitalWrite(RELAY_1, ACTIVE);
	break;
      case 'b':
        TurnOffPins();
        digitalWrite(RELAY_2, ACTIVE);
	break; 
      case 'c':
        TurnOffPins();
        digitalWrite(RELAY_3, ACTIVE);
	break;
      case 'd':
        TurnOffPins();
        digitalWrite(RELAY_4, ACTIVE);
	break;
      case 'e':
        TurnOffPins();
        digitalWrite(RELAY_5, ACTIVE);
	break; 
      case 'f':
        TurnOffPins();
        digitalWrite(RELAY_6, ACTIVE);
	break; 
      case 'g':
        TurnOffPins();
        digitalWrite(RELAY_7, ACTIVE);
	break;  
      case 'h':
        TurnOffPins();
        digitalWrite(RELAY_8, ACTIVE);
	break;             

      default:		
        // Turn all the relays off.
        TurnOffPins();
    }
  }
}
