# RabbitMQ Instruction for using

## Go to installed rabbitmq/sbin folder
> cd %PROGRAMFILES%\RabbitMQ Server\rabbitmq_server-3.9.7\sbin

## Register user
* Add new user with username - myUser and password myPass
> rabbitmqctl add_user myUser myPass
* Add administrator tag to user
> rabbitmqctl set_user_tags myUser administrator
* Set user to access virtual host "/"
> rabbitmqctl set_permissions -p "/" "myUser" ".*" ".*" ".*"

## Accessing 
http://localhost:15672/