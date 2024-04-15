USE HotelManagement

INSERT INTO dbo.room (room_number, room_type, price_per_night, availability)
VALUES (101, 'Deluxe', 200, 1),
       (102, 'Standard', 150, 1),
       (103, 'Deluxe', 200, 0),
       (104, 'Standard', 150, 1);

INSERT INTO dbo.customer (first_name, last_name, email, phone_number)
VALUES ('John', 'Doe', 'john.doe@example.com', '1234567890'),
       ('Jane', 'Doe', 'jane.doe@example.com', '0987654321'),
       ('Bob', 'Smith', 'bob.smith@example.com', '4567890123'),
       ('Alice', 'Johnson', 'alice.johnson@example.com', '3214567890');

INSERT INTO dbo.booking (customer_id, room_id, check_in_date, check_out_date)
VALUES (1, 101, '2023-01-01', '2023-01-03'),
       (2, 102, '2023-01-02', '2023-01-04'),
       (3, 103, '2023-01-03', '2023-01-05'),
       (4, 104, '2023-01-04', '2023-01-06');

INSERT INTO dbo.facility (facility_name)
VALUES ('Gym'),
       ('Spa'),
       ('Swimming Pool'),
       ('Restaurant');

INSERT INTO dbo.room_to_facility (room_id, facility_id)
VALUES (101, 1),
       (101, 2),
       (102, 3),
       (103, 4),
       (104, 1),
       (104, 2);