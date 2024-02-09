db = db.getSiblingDB("MessengerDb");

// User Indizes
db.users.createIndex({ name: 1 }, { name: "User_name_index" });
