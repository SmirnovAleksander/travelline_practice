SELECT * FROM room 
JOIN 
    booking ON booking.room_id = room.room_id
WHERE
    (GETFATE() NOT BETWEEN booking.check_in_date AND booking.check_out_date) AND room.availability = 1


SELECT *    
FROM 
    customer
WHERE 
    customer.last_name LIKE 'S%'


SELECT *
FROM booking
JOIN 
    customer ON booking.customer_id = customer.customer_id
WHERE 
    customer.first_name = 'Smith' OR customer.email = 'bob.smith@example.com'
    

SELECT *
FROM 
    booking
JOIN
    room ON booking.room_id = room.room_id
WHERE 
    room.room_number = 101


SELECT *
FROM 
    room
JOIN
    booking ON room.room_id = booking.room_id
WHERE
    room.availability = 1 AND ('2023-01-06' NOT BETWEEN booking.check_in_date AND booking.check_out_date)