# WebApplicationService
# Microservices - Lab 1
## Team
- Denys Grynenko: [AutoService](https://github.com/Gr1nchikJ/Services_Lab1/blob/master/Auto.cs), [AutoController](https://github.com/Gr1nchikJ/Services_Lab1/blob/master/Controllers/AutoController.cs)
- Denys Sorokin: [CalendarService](https://github.com/Gr1nchikJ/Services_Lab1/blob/master/Calendar.cs), [CalendarController](https://github.com/Gr1nchikJ/Services_Lab1/blob/master/Controllers/CalendarController.cs)
- Stanislav Logvynskyi: ... service
- Vadym Kozachenko: ... service

## Guideline
Посилання на Docker Hub:
link

За завданням лабораторної роботи, було створено 4 сервiси.
Для запуску одновузлового кластера Kubernetes, було використано Docker Desktop.
Для зовнiшнього доступу до сервiсiв у кластерi, було використано Ingress.

## Screenshots
![image](https://i.imgur.com/DEAfmt9.jpg)
![image](https://i.imgur.com/9tIaT9Y.png)

## Для запуску:
docker build -t service1:0.1 -f services/service1/Dockerfile . - створення image
docker run -p 8080:80 service1:0.1 - запуск контейнеру
docker ps -a - всі images
docker stop gracious_turing - зупиняє контейнер
docker start gracious_turing
kubectl config current-context - перевіряє контекст
kubectl config get-contexts
kubectl config use-context "context"
kubectl apply -f deployment.yaml
kubectl get pods
kubectl -f apply ingress.yaml
kubectl expose deployment hello-kubernetes --type=NodePort
