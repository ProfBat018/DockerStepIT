Theme: Ports, Volumes, Networks

## Ports

Our OS don't see port of docker container, but we see IP address. We should map(marry) it.
```dockerfile
docker run -d -p 5000:5000 <name>
```
* -p - publish
* 5000:5000 - map port 5000 of container to port 5000 of OS
* 5000 - port of OS
* 5000 - port of container
* <name> - name of image

## Volumes

Must have to know what is volume and bind mount.
* Volume types
* * Mount. Mount, when docker do everything by himself
* * Bind. Bind, when we say what and where docker should store data 

```dockerfile
docker volume create <name>
```

```dockerfile
docker run -d -p 5000:5000 -v <path>:<path> <name>
```
* -v - volume
* <path>:<path> - map path of container to path of OS

---------------------------------------------
After creating a docker image we can see this folder
<br>

![img.png](img.png)

```dockerfile
docker rrun -it --mount type=bind,source="$(pwd)"/app,target=/app <name>
```

* --mount - mount
* type=bind - type of mount
* source="$(pwd)"/app - path of OS
* target=/app - path of container
* <name> - name of image

# Networking - Basic
Bridge network - default network
Bridge is - virtual connection between docker containers

```dockerfile
docker network ls
```


In Docker, both overlay networks and bridge networks are used for container networking. However, they have some differences in terms of their purpose and usage.

A bridge network is a built-in Docker network that connects multiple containers running on the same host machine. It allows containers to communicate with each other through a virtual bridge, which acts as a router between the containers. By default, all containers are connected to the bridge network, and Docker creates a unique IP address for each container on that network.

On the other hand, an overlay network is a network that connects multiple Docker nodes or hosts, allowing containers running on different hosts to communicate with each other. This enables containers to be deployed across multiple hosts, creating a distributed application architecture. When a container sends data over an overlay network, Docker encapsulates the data and sends it to the appropriate destination node.

In summary, the main differences between overlay networks and bridge networks are:

Bridge networks are used for communication between containers on the same host, while overlay networks are used for communication between containers running on different hosts.
Bridge networks are automatically created by Docker, while overlay networks need to be explicitly created using the Docker CLI or API.
Bridge networks use the Docker daemon's built-in networking capabilities, while overlay networks use an external key-value store to manage network state and configuration.

---------------------------------------------


