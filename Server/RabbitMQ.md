# RabbitMQ Instruction for using

# Installation
* Install ERLANG from https://www.erlang.org/downloads
* Install RabbitMQ from https://www.rabbitmq.com/download.html

## Go to installed rabbitmq/sbin folder
* **Open CMD as Administrator**
* **Go to installed rabbitmq script folder**
> cd %PROGRAMFILES%\RabbitMQ Server\rabbitmq_server-3.9.7\sbin

## Enable Management Plugin
> rabbitmq-plugins enable rabbitmq_management

## Register user
* Add new user with username - myUser and password myPass
> rabbitmqctl add_user myUser myPass
* Add administrator tag to user
> rabbitmqctl set_user_tags myUser administrator
* Set user to access virtual host "/"
> rabbitmqctl set_permissions -p "/" "myUser" ".*" ".*" ".*"

## Accessing 
http://localhost:15672/