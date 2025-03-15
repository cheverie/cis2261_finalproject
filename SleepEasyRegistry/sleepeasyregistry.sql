
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
--
DROP DATABASE IF EXISTS sleepeasyregistry;
CREATE DATABASE sleepeasyregistry;
USE sleepeasyregistry;

CREATE TABLE `billing` (
  `billingId` int(11) NOT NULL,
  `regId` int(11) NOT NULL,
  `chargeId` int(11) NOT NULL,
  `serviceChargeTotal` double NOT NULL,
  `regTotal` double NOT NULL,
  `totalDue` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `billing`
--

INSERT INTO `billing` (`billingId`, `regId`, `chargeId`, `serviceChargeTotal`, `regTotal`, `totalDue`) VALUES
(1, 1000, 1, 25, 450, 475),
(2, 1000, 2, 50, 450, 500),
(3, 1001, 3, 30, 300, 330);

-- --------------------------------------------------------

--
-- Table structure for table `registration`
--

CREATE TABLE `registration` (
  `regId` int(11) NOT NULL,
  `roomNum` int(11) NOT NULL,
  `empId` int(11) NOT NULL,
  `roomRate` double NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `address` text NOT NULL,
  `payMethod` varchar(50) NOT NULL,
  `currentStatus` varchar(20) NOT NULL,
  `checkInDate` date NOT NULL,
  `checkOutDate` date DEFAULT NULL,
  `stayDuration` int(11) NOT NULL,
  `costOfStay` double NOT NULL,
  `email` varchar(100) NOT NULL,
  `phoneNumber` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`regId`, `roomNum`, `empId`, `roomRate`, `lastName`, `firstName`, `address`, `payMethod`, `currentStatus`, `checkInDate`, `checkOutDate`, `stayDuration`, `costOfStay`, `email`, `phoneNumber`) VALUES
(1000, 101, 1, 150, 'Doe', 'Jane', '123 Elm Street', 'Credit Card', 'Checked-In', '2025-02-19', '2025-02-22', 3, 450, 'jane.doe@email.com', '123-456-7890'),
(1001, 102, 2, 100, 'Brown', 'Chris', '456 Oak Avenue', 'Debit Card', 'Checked-Out', '2025-02-15', '2025-02-18', 3, 300, 'chris.brown@email.com', '987-654-3210'),
(1004, 104, 3, 200, 'Smith', 'Alex', '789 Pine Road', 'Credit Card', 'Checked-In', '2025-03-01', '2025-03-05', 4, 800, 'alex.smith@email.com', '555-123-4567'),
(1005, 105, 2, 175, 'Johnson', 'Emily', '321 Maple Street', 'Debit Card', 'Registered', '2025-03-03', '2025-03-07', 4, 700, 'emily.johnson@email.com', '555-987-6543'),
(1006, 106, 3, 120, 'Taylor', 'Michael', '987 Birch Lane', 'Cash', 'Checked-Out', '2025-02-28', '2025-03-02', 2, 240, 'michael.taylor@email.com', '555-654-7890'),
(1007, 107, 1, 300, 'Anderson', 'Sophia', '654 Cedar Drive', 'Credit Card', 'Checked-In', '2025-03-05', '2025-03-10', 5, 1500, 'sophia.anderson@email.com', '555-321-6789');

-- --------------------------------------------------------

--
-- Table structure for table `roominventory`
--

CREATE TABLE `roominventory` (
  `roomNum` int(11) NOT NULL,
  `roomDesc` text NOT NULL,
  `roomType` varchar(50) NOT NULL,
  `roomRate` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `roominventory`
--

INSERT INTO `roominventory` (`roomNum`, `roomDesc`, `roomType`, `roomRate`) VALUES
(100, 'Standard single bed with street view', 'Standard', 75),
(101, 'King-size bed with sea view', 'Deluxe', 150),
(102, 'Double bed with city view', 'Standard', 100),
(103, 'Suite with private balcony', 'Luxury', 250),
(104, 'Single bed with garden view', 'Standard', 85),
(105, 'Queen-size bed with pool view', 'Deluxe', 120),
(106, 'Double bed with mountain view', 'Standard', 95),
(107, 'Suite with oceanfront view', 'Luxury', 275),
(108, 'King-size bed with garden view', 'Deluxe', 160),
(109, 'Single bed with city view', 'Standard', 90),
(110, 'Queen-size bed with garden view', 'Deluxe', 130),
(111, 'Studio with partial sea view', 'Standard', 110),
(112, 'Penthouse suite with panoramic city view', 'Luxury', 350),
(113, 'King-size bed with mountain view', 'Deluxe', 155),
(114, 'Double bed with park view', 'Standard', 105),
(115, 'Suite with jacuzzi and city view', 'Luxury', 300),
(116, 'Single bed with poolside view', 'Standard', 80),
(117, 'Queen-size bed with ocean view', 'Deluxe', 145),
(118, 'Family room with garden view', 'Standard', 120),
(119, 'Suite with private garden', 'Luxury', 280),
(120, 'King-size bed with city skyline view', 'Deluxe', 165),
(121, 'Double bed with city park view', 'Standard', 100),
(122, 'Queen-size bed with mountain view', 'Deluxe', 140),
(123, 'Suite with private pool', 'Luxury', 320),
(124, 'King-size bed with forest view', 'Deluxe', 170),
(125, 'Penthouse suite with rooftop terrace', 'Luxury', 400);



-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE `service` (
  `serviceId` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `price` double NOT NULL,
  `type` varchar(50) NOT NULL,
  `availability` tinyint(1) NOT NULL,
  `description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`serviceId`, `name`, `price`, `type`, `availability`, `description`) VALUES
(1, 'Room Cleaning', 25, 'Housekeeping', 1, 'Daily room cleaning service.'),
(2, 'Spa Treatment', 50, 'Wellness', 1, 'Relaxing spa experience.'),
(3, 'Laundry Service', 15, 'Housekeeping', 1, 'Laundry and ironing service.');

-- --------------------------------------------------------

--
-- Table structure for table `servicecharge`
--

CREATE TABLE `servicecharge` (
  `chargeId` int(11) NOT NULL,
  `serviceId` int(11) NOT NULL,
  `regId` int(11) NOT NULL,
  `empId` int(11) NOT NULL,
  `serviceName` varchar(100) NOT NULL,
  `servicePrice` double NOT NULL,
  `date` date NOT NULL,
  `quantity` int(11) NOT NULL,
  `total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `servicecharge`
--

INSERT INTO `servicecharge` (`chargeId`, `serviceId`, `regId`, `empId`, `serviceName`, `servicePrice`, `date`, `quantity`, `total`) VALUES
(1, 1, 1000, 1, 'Room Cleaning', 25, '2025-02-19', 1, 25),
(2, 2, 1000, 2, 'Spa Treatment', 50, '2025-02-20', 1, 50),
(3, 3, 1001, 3, 'Laundry Service', 15, '2025-02-16', 2, 30);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `empId` int(11) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `title` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`empId`, `lastName`, `firstName`, `title`) VALUES
(1, 'Smith', 'John', 'Manager'),
(2, 'Johnson', 'Emily', 'Receptionist'),
(3, 'Williams', 'Michael', 'Housekeeper');

-- --------------------------------------------------------

--
-- Table structure for table `staffauth`
--

CREATE TABLE `staffauth` (
  `empId` int(11) NOT NULL,
  `empPass` varchar(255) NOT NULL,
  `accessLevel` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staffauth`
--

INSERT INTO `staffauth` (`empId`, `empPass`, `accessLevel`) VALUES
(1, 'password123', 3),
(2, 'welcome456', 2),
(3, 'secure789', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `billing`
--
ALTER TABLE `billing`
  ADD PRIMARY KEY (`billingId`),
  ADD KEY `regId` (`regId`),
  ADD KEY `chargeId` (`chargeId`);

  ALTER TABLE billing MODIFY COLUMN chargeId INT NULL;

--
-- Indexes for table `registration`
--
ALTER TABLE `registration`
  ADD PRIMARY KEY (`regId`),
  ADD KEY `empId` (`empId`);

--
-- Indexes for table `roominventory`
--
ALTER TABLE `roominventory`
  ADD PRIMARY KEY (`roomNum`);

--
-- Indexes for table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`serviceId`);

--
-- Indexes for table `servicecharge`
--
ALTER TABLE `servicecharge`
  ADD PRIMARY KEY (`chargeId`),
  ADD KEY `serviceId` (`serviceId`),
  ADD KEY `regId` (`regId`),
  ADD KEY `empId` (`empId`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`empId`);

--
-- Indexes for table `staffauth`
--
ALTER TABLE `staffauth`
  ADD PRIMARY KEY (`empId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `registration`
--
ALTER TABLE `registration`
  MODIFY `regId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1004;

--
-- AUTO_INCREMENT for table `billing`
--
ALTER TABLE `billing` 
MODIFY `billingId` int(11) NOT NULL AUTO_INCREMENT;

-- Add AUTO_INCREMENT to serviceId in service table
ALTER TABLE `service`
  MODIFY `serviceId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

-- Add AUTO_INCREMENT to chargeId in servicecharge table
ALTER TABLE `servicecharge`
  MODIFY `chargeId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

-- Add AUTO_INCREMENT to empId in staff table
ALTER TABLE `staff`
  MODIFY `empId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `billing`
--
ALTER TABLE `billing`
  ADD CONSTRAINT `billing_ibfk_1` FOREIGN KEY (`regId`) REFERENCES `registration` (`regId`),
  ADD CONSTRAINT `billing_ibfk_2` FOREIGN KEY (`chargeId`) REFERENCES `servicecharge` (`chargeId`);

--
-- Constraints for table `registration`
--
ALTER TABLE `registration`
  ADD CONSTRAINT `registration_ibfk_1` FOREIGN KEY (`empId`) REFERENCES `staff` (`empId`);

ALTER TABLE `registration`
ADD CONSTRAINT `fk_room` FOREIGN KEY (`roomNum`) REFERENCES `roominventory` (`roomNum`);

--
-- Constraints for table `servicecharge`
--
ALTER TABLE `servicecharge`
  ADD CONSTRAINT `servicecharge_ibfk_1` FOREIGN KEY (`serviceId`) REFERENCES `service` (`serviceId`),
  ADD CONSTRAINT `servicecharge_ibfk_2` FOREIGN KEY (`regId`) REFERENCES `registration` (`regId`) ON DELETE CASCADE,
  ADD CONSTRAINT `servicecharge_ibfk_3` FOREIGN KEY (`empId`) REFERENCES `staff` (`empId`);

--
-- Constraints for table `staffauth`
--
ALTER TABLE `staffauth`
  ADD CONSTRAINT `staffauth_ibfk_1` FOREIGN KEY (`empId`) REFERENCES `staff` (`empId`);


--
-- Billing bill creation trigger
--
DELIMITER $$

CREATE TRIGGER after_check_out
AFTER UPDATE ON registration
FOR EACH ROW
BEGIN
    -- Declare variables to store the total service charge, total registration cost, and total due
    DECLARE serviceChargeTotal DECIMAL(10,2);
    DECLARE regTotal DECIMAL(10,2);
    DECLARE totalDue DECIMAL(10,2);
    
    -- Check if the currentStatus is changed to Checked-Out
    IF NEW.currentStatus = 'Checked-Out' AND OLD.currentStatus != 'Checked-Out' THEN
        
        -- Calculate the total service charge for the given regId
        SELECT SUM(servicePrice * quantity) INTO serviceChargeTotal
        FROM charges
        WHERE regId = NEW.regId;
        
        -- Get the total cost of stay from the registration table
        SELECT costOfStay INTO regTotal
        FROM registration
        WHERE regId = NEW.regId;
        
        -- Calculate the total due (service charge + registration total)
        SET totalDue = serviceChargeTotal + regTotal;
        
        -- Insert the billing record into the billing table
        INSERT INTO billing (regId, chargeId, serviceChargeTotal, regTotal, totalDue)
        SELECT NEW.regId, chargeId, serviceChargeTotal, regTotal, totalDue
        FROM charges
        WHERE regId = NEW.regId
        LIMIT 1; -- Assuming a single chargeId per registration in the billing table
        
    END IF;
END $$

DELIMITER ;