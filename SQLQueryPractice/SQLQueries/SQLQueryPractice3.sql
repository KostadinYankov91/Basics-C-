USE Airport

SELECT * FROM Planes 
WHERE Name LIKE '%tr%' 
ORDER BY Id, Name, Seats, Range ASC

--6-----------
SELECT FlightId, 
	   SUM(Price) AS Price 
FROM Flights AS f
JOIN Tickets AS t ON f.Id = t.FlightId
GROUP BY FlightId
ORDER BY Price DESC, FlightId ASC

--7-----------
SELECT * FROM 
(SELECT 
	FirstName + ' ' + LastName AS [Full Name],
	Origin AS Origin,
	Destination AS Destination
	FROM Passengers AS p
LEFT JOIN Tickets AS t ON p.Id = t.PassengerId
LEFT JOIN Flights AS f ON t.FlightId = f.Id) AS PassengersTrips
GROUP BY [Full Name], Origin, Destination
ORDER BY [Full Name], Origin, Destination ASC


SELECT *	
FROM (SELECT P.FirstName + ' ' + p.LastName AS [Full Name],
			 Origin,
			 Destination
FROM Passengers AS p
LEFT JOIN Tickets AS t ON p.Id = t.PassengerId
JOIN Flights AS f ON t.FlightId = f.Id) AS PassengerTripss
GROUP BY [Full Name], Origin, Destination
ORDER BY [Full Name] ASC, Origin ASC, Destination ASC

--8--------------
SELECT FirstName,
	   LastName,
	   Age FROM Passengers AS p
LEFT JOIN Tickets AS t ON p.Id = t.PassengerId
WHERE t.Id IS NULL
ORDER BY Age DESC, FirstName ASC, LastName ASC

--9--------------
	SELECT FirstName + ' ' + LastName AS [Full Name],
		   pl.Name AS [Plane Name],
		   f.Origin + ' - ' + f.Destination AS [Trip],
		   lp.Type AS [Luggage Type]
		   FROM Passengers AS p
	JOIN Tickets AS t ON p.Id = t.PassengerId
	JOIN Flights AS f ON t.FlightId = f.Id
	JOIN Planes AS pl ON f.PlaneId = pl.Id
	JOIN LuggageTypes AS lp ON t.LuggageId = lp.Id
	WHERE t.Id IS NOT NULL
	ORDER BY [Full Name], pl.Name, Trip, [Luggage Type]


SELECT	FirstName + ' ' + LastName AS [Full Name],
		pl.Name AS [Plane Name],
		f.Origin + ' - ' + f.Destination AS [Trip],
		lp.Type AS [Luggage Type]
		FROM Tickets AS t
LEFT JOIN Flights AS f ON t.FlightId = f.Id 
JOIN Passengers AS p ON t.PassengerId = p.Id
JOIN Planes AS pl ON f.PlaneId = pl.Id
JOIN Luggages AS l ON t.LuggageId = l.Id
JOIN LuggageTypes AS lp ON l.LuggageTypeId = lp.Id
ORDER BY [Full Name], pl.Name, Trip, [Luggage Type]

--10-------------
	   SELECT Name,
			  Seats,
			  COUNT(t.Id) AS [Passnegers Count]
FROM Planes AS p
LEFT JOIN Flights AS f ON p.Id = f.PlaneId
LEFT JOIN Tickets AS t ON f.Id = t.FlightId
GROUP BY p.Id, p.Name, p.Seats
ORDER BY [Passnegers Count] DESC, p.Name ASC, p.Seats ASC

--11--------------

CREATE FUNCTION udf_CalculateTickets(@origin VARCHAR(50), @destination VARCHAR(50), @peopleCount INT)
RETURNS VARCHAR(50) AS
BEGIN 
	IF (@peopleCount = 0) RETURN 'Invalid people count!'
	IF (NOT EXISTS (SELECT 1 FROM Flights WHERE Origin = @origin
		AND Destination = @destination)) RETURN 'Invalid flight!'
	RETURN CONCAT('Total price ', (SELECT TOP(1) ts.Price FROM Tickets AS ts
	JOIN Flights AS fl ON ts.FlightId = fl.Id
	WHERE fl.Origin = @Origin AND fl.Destination = @destination) * @peopleCount)
END

SELECT dbo.udf_CalculateTickets('Sofia', 'Plovdiv', 9)

--12------------
CREATE OR ALTER PROCEDURE usp_CancelFlights 
AS
UPDATE Flights SET 
DepartureTime = NULL, ArrivalTime = NULL
WHERE ArrivalTime > DepartureTime

EXEC usp_CancelFlights

SELECT *
	   FROM Flights
WHERE ArrivalTime > DepartureTime
