# kafka and kafka-ui

## projects web pages

### kafka
https://developer.confluent.io/quickstart/kafka-docker/

### provectus/kafka-ui
https://github.com/provectus/kafka-ui

## running docker images

```
sudo docker compose up --build -d
``` 

## testing kafka

### creating a topic

```
docker exec broker \
kafka-topics --bootstrap-server broker:9092 \
             --create \
             --topic quickstart
```

### produce message to topic

```
docker exec --interactive --tty broker \
kafka-console-producer --bootstrap-server broker:9092 \
                       --topic quickstart
```


### consume message from topic

```
docker exec --interactive --tty broker \
kafka-console-consumer --bootstrap-server broker:9092 \
                       --topic quickstart \
                       --from-beginning
```

## kafka-ui - visualizing kafka

http://localhost:8080

## example consuming message from topic using .net core 

```
cd console-app
dotnet run
```
