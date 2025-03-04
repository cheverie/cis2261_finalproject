CREATE DATABASE SleepEasyRegistry;
USE SleepEasyRegistry;

-- Staff Table
CREATE TABLE Staff (
    empId INT PRIMARY KEY,
    lastName VARCHAR(50) NOT NULL,
    firstName VARCHAR(50) NOT NULL,
    title VARCHAR(50) NOT NULL
);

-- StaffAuth Table
CREATE TABLE StaffAuth (
    empId INT PRIMARY KEY,
    empPass VARCHAR(255) NOT NULL,
    accessLevel INT NOT NULL,
    FOREIGN KEY (empId) REFERENCES Staff(empId)
);

-- Service Table
CREATE TABLE Service (
    serviceId INT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    price DOUBLE NOT NULL,
    type VARCHAR(50) NOT NULL,
    availability BOOLEAN NOT NULL,
    description TEXT
);

-- Registration Table
CREATE TABLE Registration (
    regId INT PRIMARY KEY,
    roomNum INT NOT NULL,
    empId INT NOT NULL,
    roomRate DOUBLE NOT NULL,
    lastName VARCHAR(50) NOT NULL,
    firstName VARCHAR(50) NOT NULL,
    address TEXT NOT NULL,
    payMethod VARCHAR(50) NOT NULL,
    currentStatus BOOLEAN NOT NULL,
    checkInDate DATE NOT NULL,
    checkOutDate DATE,
    stayDuration INT NOT NULL,
    costOfStay DOUBLE NOT NULL,
    email VARCHAR(100) NOT NULL,
    phoneNumber VARCHAR(20) NOT NULL,
    FOREIGN KEY (empId) REFERENCES Staff(empId)
);

-- RoomInventory Table
CREATE TABLE RoomInventory (
    roomNum INT PRIMARY KEY,
    roomDesc TEXT NOT NULL,
    roomType VARCHAR(50) NOT NULL,
    roomRate DOUBLE NOT NULL
);

-- ServiceCharge Table
CREATE TABLE ServiceCharge (
    chargeId INT PRIMARY KEY,
    serviceId INT NOT NULL,
    regId INT NOT NULL,
    empId INT NOT NULL,
    serviceName VARCHAR(100) NOT NULL,
    servicePrice DOUBLE NOT NULL,
    date DATE NOT NULL,
    quantity INT NOT NULL,
    total DOUBLE NOT NULL,
    FOREIGN KEY (serviceId) REFERENCES Service(serviceId),
    FOREIGN KEY (regId) REFERENCES Registration(regId),
    FOREIGN KEY (empId) REFERENCES Staff(empId)
);

-- Billing Table
CREATE TABLE Billing (
    billingId INT PRIMARY KEY,
    regId INT NOT NULL,
    chargeId INT NOT NULL,
    serviceChargeTotal DOUBLE NOT NULL,
    regTotal DOUBLE NOT NULL,
    totalDue DOUBLE NOT NULL,
    FOREIGN KEY (regId) REFERENCES Registration(regId),
    FOREIGN KEY (chargeId) REFERENCES ServiceCharge(chargeId)
);

-- Sample Data
INSERT INTO Staff (empId, lastName, firstName, title) VALUES
(1, 'Smith', 'John', 'Manager'),
(2, 'Johnson', 'Emily', 'Receptionist'),
(3, 'Williams', 'Michael', 'Housekeeper');

INSERT INTO StaffAuth (empId, empPass, accessLevel) VALUES
(1, 'password123', 3),
(2, 'welcome456', 2),
(3, 'secure789', 1);

INSERT INTO Service (serviceId, name, price, type, availability, description) VALUES
(1, 'Room Cleaning', 25.00, 'Housekeeping', TRUE, 'Daily room cleaning service.'),
(2, 'Spa Treatment', 50.00, 'Wellness', TRUE, 'Relaxing spa experience.'),
(3, 'Laundry Service', 15.00, 'Housekeeping', TRUE, 'Laundry and ironing service.');

INSERT INTO RoomInventory (roomNum, roomDesc, roomType, roomRate) VALUES
(101, 'King-size bed with sea view', 'Deluxe', 150.00),
(102, 'Double bed with city view', 'Standard', 100.00),
(103, 'Suite with private balcony', 'Luxury', 250.00);

INSERT INTO Registration (regId, roomNum, empId, roomRate, lastName, firstName, address, payMethod, currentStatus, checkInDate, checkOutDate, stayDuration, costOfStay, email, phoneNumber) VALUES
(1000, 101, 1, 150.00, 'Doe', 'Jane', '123 Elm Street', 'Credit Card', TRUE, '2025-02-19', '2025-02-22', 3, 450.00, 'jane.doe@email.com', '123-456-7890'),
(1001, 102, 2, 100.00, 'Brown', 'Chris', '456 Oak Avenue', 'Debit Card', FALSE, '2025-02-15', '2025-02-18', 3, 300.00, 'chris.brown@email.com', '987-654-3210');

INSERT INTO ServiceCharge (chargeId, serviceId, regId, empId, serviceName, servicePrice, date, quantity, total) VALUES
(1, 1, 1, 1, 'Room Cleaning', 25.00, '2025-02-19', 1, 25.00),
(2, 2, 1, 2, 'Spa Treatment', 50.00, '2025-02-20', 1, 50.00),
(3, 3, 2, 3, 'Laundry Service', 15.00, '2025-02-16', 2, 30.00);

INSERT INTO Billing (billingId, regId, chargeId, serviceChargeTotal, regTotal, totalDue) VALUES
(1, 1, 1, 25.00, 450.00, 475.00),
(2, 1, 2, 50.00, 450.00, 500.00),
(3, 2, 3, 30.00, 300.00, 330.00);
