# Our aim is infrustucture. What we gonna learn ? 
* Docker
* Kubernetes
* redis
* rabbitmq
* Other tools 

# Related Links
* [What docker exactly is](https://medium.com/swlh/what-exactly-is-docker-1dd62e1fde38)
* [Docker docs](https://docs.docker.com/get-started/)
* [Dockerfile reference](https://docs.docker.com/engine/reference/builder/)
* [Dockerfile best practices](https://docs.docker.com/develop/develop-images/dockerfile_best-practices/)


### History of containers
* 1979 - chroot
* 2000 - FreeBSD Jails
* 2001 - Linux VServer
* 2004 - Solaris Containers
* 2005 - OpenVZ
* 2006 - Process Containers
* 2008 - LXC
* 2011 - Docker
* 2013 - Kubernetes
* 2014 - Mesos
* 2014 - Docker Swarm
* 2014 - CoreOS
* 2015 - Mesosphere DC/OS
* 2015 - Amazon ECS
* 2016 - Docker Datacenter
* 2016 - Rancher
* 2016 - Nomad
* 2017 - CRI-O
* 2017 - Containerd
* 2017 - CRI Containerd
* 2017 - Kata Containers
* 2017 - Fargate
* 2018 - Firecracker
* 2018 - Knative

* Docker - is platform, who provide you to build, ship and run your application
* Docker was first, who bring the concept of Image

![containers-vs-virtual-machines.jpg](containers-vs-virtual-machines.jpg)


# Pros of docker
* scalability
* security
* availability
* performance
* easy production 
* easy development

# Docker was written in GoLang for unix systems

# For windows and mac os docker use virtual machine
* HyperV for windows
* xhyve for mac os
* * Related
* * * WSL - Windows Subsystem for Linux
* * * WSL2 - Windows Subsystem for Linux 2
* * * WSLg - Windows Subsystem for Linux GUI

# Docker architecture
* Docker client
* Docker daemon 
* Docker registry
* Docker objects
* * Images


What is daemon ? 
* A daemon is a computer program that runs as a background process, rather than being under the direct control of an interactive user.
* A daemon is a process that runs in the background and has no controlling terminal.

What is Registry ?
* A registry is a stateless, highly scalable server side application that stores and lets you distribute Docker images.
* The registry is open-source, under the permissive Apache license.
* The registry is a stateless, scalable server-side application that stores and lets you distribute Docker images. The registry is open-source, under the permissive Apache license.

Docker Image ?
* An image is a read-only template with instructions for creating a Docker container. Often, an image is based on another image, with some additional customization. For example, you may build an image which is based on the ubuntu image, but installs the Apache web server and your application, as well as the configuration details needed to make your application run.

* <br>
1. Select Image
2. Select packages

_____________________
Docker Hub [https://hub.docker.com/]

### To run Image
* DockerFile - is a file, where you can write instructions for docker
* Docker Compose 
* Docker Run - is a command, where you can run docker image


##  Dockerfile

```dockerfile
FROM node:18-alpine
WORKDIR /app
COPY .. .
RUN yarn install --production
CMD ["node", "src/index.js"]
```

## Docker Compose
```yaml
version: "3.8"
services:
  web:
    build: .
    ports:
      - "5000:5000"
    volumes:
      - .:/app
    environment:
      NODE_ENV: production
  redis:
    image: "redis:alpine"
```

## Docker Run
```bash
docker run -d -p 5000:5000 --name web web
```

