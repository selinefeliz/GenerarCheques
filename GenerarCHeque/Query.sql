create table cheque(
	idcheck int identity primary key,
	company_name varchar(200),
	date_check date default getDate(),
	amount decimal(18,2),
	pay_the_order_of varchar(100),
	memo varchar(150)
)
select * from cheque