WebService para Integracion con FarmAgro
========================================

Esta carpeta, contiene la logica del WebService para FarmAgro.
Tambien se provee un WebService que por razones de infraestructura se brinda
para poder contar con BasicAuthentication.

Proyectos:
----------

* FTP
* WebServiceDatos
* WebServiceLogica
* WebServiceTLA
* WebServiceTLAExterno

FTP
---

Este proyecto contiene codigo relacionado con conexion y subida de archivos por FTP

WebServiceDatos
---------------

Este proyecto contiene codigo relacionado con conexion a base de datos y ejecucion de estatutos de SQL

WebServiceLogica
----------------

Este proyecto contiene la logica relacionada con las acciones necesarias en la integracion con FarmAgro

WebServiceTLA
-------------

WebService de uso interno

WebServiceTLAExterno
--------------------

WebService para ser usado por clientes externos conectandose por BasicAuthentication
Actualmente solo permite un usuario que debe ser especificado en el Web.Config
con las entradas FarmAgroUser y FarmAgroPassword para usuario y password correspondientemente.
