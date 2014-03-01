<?php

 $username=trim($_POST['user_name']); 
 $password=trim($_POST['pass_word']);
$wsdl = 'http://localhost:57540/DMSService.svc?wsdl';
$soapClient = new SoapClient($wsdl);
$retValue = $soapClient->Login(array(
                          "id" => $username,
                          "pwd" => $password));
                          
var_dump($retValue);

?>