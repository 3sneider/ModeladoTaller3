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

En este documento usted encontrara toda la informacion dnecesariapara la integracion con el sistema financiero del Banco ABC. Se incluyen ejemplos que clarifican el correcto uso del sistema.

# Start Up <a name="start-up"></a>

Debe conocer su usuario, este sera indispensable para poder dar comienzo al llamado de nuestros servicios.

# Request Services <a name="request-services"></a>

La dirección web del servicio es: xxxxxxxxxxxxx.

Todo se desarrolla en un entorno de produccion debidamente validado y testeado, cualquir incidencia debe ser reportada a fin de validar su correcto uso.

# List of Services <a name="list-of-Services"></a>

## Validate User (Action 1) <a name="validate-user"></a>

Esta accion permite validar la existencia de un usuario, la validacion de forma ooleana nos indicara si el usuario esta o no validado.

Request: URL-Request
Format:

## Load Services (Action 2) <a name="load-services"></a>

Mostrara una lista de los servicios publicos pendientes de los cuales podra seleccionar uno y realizar el correspondiente pago.

Request: URL-Request
Format:

## Load Payment Methods (Action 3) <a namme="load-payment-methods"></a>

Se tendra la opcion de seleccionar entre los medios de pago mas populares y accesibles. 

Request: URL-Request
Format:

## Validate Balance (Action 4) <a name="validate-balance"></a>

Segun el tipo de pago seleccionado se podra hacer la validacion si el medio de pago cuenta o no con el cupo necesario para el edbito del pago

Request: URL-Request
Format:

## Correct Transaction (Action 5) <a name="correct-transaction"></a>

Una ves se ha finalizado el proceso, se envia un mensaje de notificaion al cliente,

Request: URL-Request
Format:

