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
* Volume - is a special directory in container, which is stored in container. It is not stored in image.
* Bind mount - is a directory in OS, which is mapped to directory in container. It is stored in OS.


```dockerfile
dokcer volume create <name>
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