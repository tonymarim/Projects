void setup() {
    Serial.begin(9600);
}

void loop() {
    if (Serial.available() > 0) {
        String comando = Serial.readStringUntil('\n');
        if (comando == "AT") {
            Serial.println("OK"); // Responde ao comando de teste
        }
    }
}