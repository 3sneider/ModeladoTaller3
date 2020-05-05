# Table of contents <a name="table-of-contents"></a>
1. [Description](#description)
2. [Start Up](#start-up)
3. [Request Services](#request-services)
4. [List of Services](#list-of-Services)
    1. [Validate User (Action 1)](#validate-user)
    2. [Load Services (Action 2)](#load-services)
    3. [Load Payment Methods (Action 3)](#load-payment-methods)
    4. [Validate Balance (Action 4)](#validate-balance)    
    5. [Correct Transaction (Action 5)](#correct-transaction)


# Description <a name="description"></a>

En este documento usted encontrara toda la información necesaria para la integración con el sistema financiero del Banco ABC. Se incluyen ejemplos que clarifican el correcto uso del sistema.

La arquitectura está basada en SOA, hay una variedad de servicios con una única responsabilidad de tipo REST y SOAP, estos son orquestados por una WEB_API llamada OfertasApi que utiliza Apache KAFKA, el cual trabaja con el patron de software publish and suscribe, cuando se realiza una petición del Api de acuerdo a los parámetros del request, este sabe con qué servicio interactuar para obtener la información deseada, esta Api trabaja en conjunto con KAFKA para que se produzca un Topico, cuando el Topico se genera alli estara asociada la información producida por el servicio utilizado.

Consumer del Topico, también se ofrece la parte de suscripción a topicos, aqui hay servicios que actuan como consumidores de topicos producidos, es allí donde se suscriben a un topico que se expone en la arquitectura del Api OfertasApi, cuando se consume un topic, podemos obtener la información que este tiene asignada.


# Start Up <a name="start-up"></a>

Debe conocer su usuario, este sera indispensable para poder dar comienzo al llamado de nuestros servicios.

# Request Services <a name="request-services"></a>

La dirección web del servicio es: http://ofertasbsapi.azurewebsites.net/api/users
Tipo de servicio : REST 

Todo se desarrolla en un entorno de produccion debidamente validado y testeado, cualquir incidencia debe ser reportada a fin de validar su correcto uso.

A continuacion se brinda el detalle de cada uno de los servicios y se exponen los endpoint de cada servicio

Se estableceran los metodos POST Y GET de cada endpoint

# List of Services <a name="list-of-Services"></a>

## Validate User (Action 1) <a name="validate-user"></a>

Esta accion permite validar la existencia de un usuario, la validacion de forma Booleana nos indicara si el usuario esta o no validado.

GET 
Request: http://ofertasbsapi.azurewebsites.net/api/kafka/kafka/ValidateUser?user=User 
Parameter: Name: user:   Type Date : string     
Response : Boolean   
Format:JSON 
Tipo de servicio consumido:  REST 


Este servicio realiza la validacion de usuario, y valida si esta autenticado.

## Load Services (Action 2) <a name="load-services"></a>

Mostrara una lista de los servicios publicos pendientes de los cuales podra seleccionar uno y realizar el correspondiente pago.
GET
Request: http://ofertasbsapi.azurewebsites.net/api/kafka/LoadServices?topic=servicio1
Parameter: Name: topic:   Type Date : string     
Response : array list string    
Format:JSON 
Tipo de servicio consumido:  REST 

Este servicio recibe un parametro llamado Topic, asi el topico generado en kafka sera parametrico para que el consumidor sepa a cual topico suscribirse.

## Load Payment Methods (Action 3) <a namme="load-payment-methods"></a>

Se tendra la opcion de seleccionar entre los medios de pago mas populares y accesibles. 

GET
Request: http://ofertasbsapi.azurewebsites.net/api/kafka/MediosdePago?topic=alejo2
Parameter: Name: topic   Type Date : string     
Response : array list string    
Format:JSON 
Tipo de servicio consumido:  REST 

Este servicio recibe un parametro llamado Topic, asi el topico generado en kafka sera parametrico para que el consumidor sepa a cual topico suscribirse.

## Validate Balance (Action 4) <a name="validate-balance"></a>

Segun el tipo de pago seleccionado se podra hacer la validacion si el medio de pago cuenta o no con el cupo necesario para el edbito del pago

GET
Request: http://ofertasbsapi.azurewebsites.net/api/kafka/ValidateBalance?numberTarjet=10
Parameter: Name: numberTarjet   Type Date : string     
Response : Boolean  
Format:JSON
Tipo de servicio consumido:  REST 

## Correct Transaction (Action 5) <a name="correct-transaction"></a>

Una ves se ha finalizado el proceso, se envia un mensaje de notificaion al cliente,
GET
Request: http://ec2-3-22-102-75.us-east-2.compute.amazonaws.com:83/api/OK/correctTransaction 
Response : Ok status 200  
Format:JSON
Tipo de servicio consumido:  REST 

## Pago de servicio Gas (Action 5) <a name="gas-service-soap"></a>

Este es el servicio para poder realizar los pagos de la factura del Gas

GET 
Consultar Factura
Request1: http://ec2-3-22-102-75.us-east-2.compute.amazonaws.com:83/api/kafka/getFactura?referenciaFactura=A
Parameter: Name: referenciaFactura   Type Date : string     
Response : array List 
Format:JSON
Tipo de servicio consumido:  SOAP 

post 
Compensar Pago Factura
Request2: http://ec2-3-22-102-75.us-east-2.compute.amazonaws.com:83/api/kafka/PagoCompensar?referenciaFactura=A&valorTotal=2000
Parameter: Name: referenciaFactura   Type Date : string  
           Name: valorTotal          Type Date : double    
Response : array List 
Format:JSON
Tipo de servicio consumido:  SOAP 

post 
Pago Factura
Request3: http://ec2-3-22-102-75.us-east-2.compute.amazonaws.com:83/api/kafka/PagoFactura?referenciaid=A&valorTotalfact=2000
Parameter: Name: referenciaid    Type Date : string  
           Name: valorTotalfact  Type Date : double  
Response : array List  de confirmacion de pago
Format:JSON
Tipo de servicio consumido:  SOAP 

## Pago de servicio AGUA (Action 5) <a name="water-service-rest"></a>

Este es el servicio para poder realizar los pagos de la factura del Agua 

Get 
Consultar Factura Agua 
Request3: http://ec2-3-22-102-75.us-east-2.compute.amazonaws.com:83/api/kafka/ConsultaFactura/
Parameter: Name: numeroFactura    Type Date : int 
           Name: topic            Type Date : string 
 
   
Response : array List  
Format:JSON
Tipo de servicio consumido:  SOAP 
