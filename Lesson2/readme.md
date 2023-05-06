# Docker run 
* create docker file
* create image 
* run image
* docker run


1. Docker file is for image 

To use docker commands we need to know some flags
* -d - run in background
* -p - publish
* -v - volume
* -it - interactive terminal
* --name - name of container
* --rm - remove container after stop
* --restart - restart container after stop
* --network - network
* --link - link to other container
* --env - environment variable
* --env-file - environment variable from file
* --workdir - working directory
* --user - user
* --entrypoint - entrypoint
* --mount - mount
* --device - device
* --privileged - privileged
* --cap-add - cap add
* --cap-drop - cap drop
* --security-opt - security opt
* --label - label
* --log-driver - log driver
* --log-opt - log opt


## First docker run commands
* docker run -d -p 5000:5000 <name>
* docker run -d -p 5000:5000 <name> <command>
* docker run -d -p 5000:5000 <name> <command> <args>
* docker run -it <name> <command> <args>
* * -i - interactive. Interactive mode is used for running interactive applications such as a shell.
* * -t - terminal. -t is TTYS (pseudo-tty) mode, which is used for running terminal applications.
* * -it - interactive terminal. -it is a combination of -i and -t.

for images we can use [HUB](hub.docker.com)
## Docker commands
* docker run
* docker ps
* docker ps -a
* docker images
* docker build
* docker build -t <name> .
* docker build -t <name> <path>
* docker build -t <name> <url>
* docker build -t <name> <git>
* docker build -t <name> <git>#<branch>



Example with ubuntu from registry

```dockerfile
docker run -it ubuntu ls/
```

we will get error because we don't have image ubuntu, but we can download it from registry automatically
<br>

not all images id available for -it mode. ubuntu image is not available for -it mode

we could write it with 
```dockerfile
FROM ubuntu
```
but it will create new layer, and it will be not good
instead of it we can use `docker run -it ubuntu ls/`
<br>
P.S. It's good only for small commands, for big commands we should use Dockerfile

