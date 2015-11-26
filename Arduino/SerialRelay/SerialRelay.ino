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
#define RELAY_8 13

#define ACTIVE = LOW

void setup() {
  // Initialize pins. Set all pins inactive.
  for (int thisPin = 2; thisPin < 14; thisPin++) {
    pinMode(thisPin, OUTPUT);
    digitalWrite(thisPin, !ACTIVE);
  }

  // Initialize serial communication.
  Serial.begin(9600);   
  Serial.WriteLine("SerialRelay V1.0");
  Serial.WriteLine("Ready ...");	
}

void TurnOffPins() {
  for (int thisPin = 2; thisPin < 14; thisPin++) {
    digitalWrite(thisPin, !ACTIVE);
  }
}

void loop() {
  // read the sensor:
  if (Serial.available() > 0) {
    String inByte = Serial.readString();
      
    switch (inByte) { 
      case 'A':  
        TurnOffPins();
        digitalWrite(RELAY_1, ACTIVE);
	break;
      case 'B':
        TurnOffPins();
        digitalWrite(RELAY_2, ACTIVE);
	break; 
      case 'C':
        TurnOffPins();
        digitalWrite(RELAY_3, ACTIVE);
	break;
      case 'D':
        TurnOffPins();
        digitalWrite(RELAY_4, ACTIVE);
	break;
      case 'E':
        TurnOffPins();
        digitalWrite(RELAY_5, ACTIVE);
	break; 
      case 'F':
        TurnOffPins();
        digitalWrite(RELAY_6, ACTIVE);
	break; 
      case 'G':
        TurnOffPins();
        digitalWrite(RELAY_7, ACTIVE);
	break;  
      case 'H':
        TurnOffPins();
        digitalWrite(RELAY_8, ACTIVE);
	break;             

      default:		
        // Turn all the relays off.
        TurnOffPins();
    }
  }
}
