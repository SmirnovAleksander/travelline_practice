IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'room')
    CREATE TABLE room (
        room_id INT IDENTITY(1,1) NOT NULL,
        room_number INT NOT NULL,
		room_type NVARCHAR(50) NOT NULL,
		price_per_night MONEY NOT NULL,
		availability BIT NOT NULL,

		CONSTRAINT PK_room_id PRIMARY KEY (room_id)
    )

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'customer')
    CREATE TABLE customer (
        customer_id INT IDENTITY(1,1) NOT NULL,
        first_name NVARCHAR(50) NOT NULL,
		last_name NVARCHAR(50) NOT NULL,
		email NVARCHAR(50) NOT NULL,
		phone_number NVARCHAR(50) NOT NULL,

		CONSTRAINT PK_customer_id PRIMARY KEY (customer_id)
    )
