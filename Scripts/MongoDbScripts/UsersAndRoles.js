adminDatabase = db.getSiblingDB("admin");
messengerDb = db.getSiblingDB("MessengerDb");

if (!adminDatabase.getUser("superadmin")) {
  adminDatabase.createUser({
    user: "superadmin",
    pwd: "password",
    roles: ["root"],
  });
}

if (!messengerDb.getRole("customRole")) {
  messengerDb.createRole({
    role: "customRole",
    privileges: [
      {
        resource: { db: "MessengerDb", collection: "" },
        actions: ["find", "insert", "update", "remove"],
      },
    ],
    roles: [],
  });
}

if (!messengerDb.getUser("johny")) {
  messengerDb.createUser({
    user: "johny",
    pwd: "password",
    roles: ["customRole"],
  });
}
