// Verbindung zur Admin-Datenbank herstellen
adminDatabase = db.getSiblingDB("admin");
messengerDb = db.getSiblingDB("MessengerDb");

// Überprüfen und Löschen des Benutzers "sAdmin", falls vorhanden
if (adminDatabase.getUser("superadmin")) {
  adminDatabase.dropUser("superadmin");
  print("Benutzer superadmin wurde gelöscht.");
} else {
  print("Benutzer superadmin existiert nicht.");
}

// Überprüfen und Löschen des Benutzers "johny", falls vorhanden
if (messengerDb.getUser("johny")) {
  messengerDb.dropUser("johny");
  print("Benutzer johny wurde gelöscht.");
} else {
  print("Benutzer johny existiert nicht.");
}

// Wechsel zur JetStreamApiDb-Datenbank
messengerDb = db.getSiblingDB("MessengerDb");

// Überprüfen, ob die Datenbank "JetStreamApiDb" existiert und sie löschen
existingDbs = db
  .adminCommand("listDatabases")
  .databases.map((dbInfo) => dbInfo.name);
if (existingDbs.includes("MessengerDb")) {
  messengerDb.dropDatabase();
  print("Datenbank MessengerDb wurde gelöscht.");
} else {
  print("Datenbank MessengerDb existiert nicht.");
}
