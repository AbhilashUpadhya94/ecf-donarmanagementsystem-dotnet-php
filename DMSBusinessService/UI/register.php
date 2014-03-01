<?php

 $fname=trim($_POST['first_name']); 
 $lname=trim($_POST['last_name']); 
 $gender=trim($_POST['gender']); 
 $address=trim($_POST['address']);
 $state=trim($_POST['state']);
 $country=trim($_POST['country_id']);
 $middlename=trim($_POST['middle_name']);
 $mail=trim($_POST['mail']);
 $dob=trim($_POST['dob']);
 $month=trim($_POST['month']);
 $year=trim($_POST['year']);
 $pincode=trim($_POST['pincode']);
 $city=trim($_POST['city']);
 $contact_number=trim($_POST['contact_number']);
 //$password=trim($_POST['password']);
/*$userinfo->Gender => "Male";
$userinfo->UserName => $mail;
$userinfo->Password => "vijay1";
$userinfo->Intials => "Mr.";
$userinfo->FirstName => $fname;
$userinfo->LastName => $lname;
$userinfo->Dob => $dob;
$userinfo->Address => $address;
$userinfo->City => $city;
$userinfo->State => $state;
$userinfo->PinCode => $pincode;
$userinfo->Country => $country;
$userinfo->Contact => $contact_number;
$userinfo->Contact1 => $contact_number;
$userinfo->MiddleName => $middlename;
$paramenters->userInfo => $userInfo;*/
$wsdl = 'http://localhost:57540/DMSService.svc?wsdl';
$soapClient = new SoapClient($wsdl);
$soapClient->Register(array("userInfo"=>array(
"Gender" => "Male",
                                        "UserName" => $mail,
                                        "Password" => "vijay1",
                                        "Intials" => "Mr.",
                                        "FirstName" => $fname,
                                        "LastName" => $lname,
                                        "Dob" => $year."-".$month."-".$dob,
                                        "Address" => $address,
                                        "City" => $city,
                    "State" => $state,
                    "PinCode" => $pincode,
                    "Country" => $country,
                    "Contact" => $contact_number,
                    "Contact1" => $contact_number,
                    "MiddleName" => $middlename)));







        echo $fname         
         ,$lname            
         ,$gender           
         ,$address          
         ,$state            
         ,$country          
         ,$middlename       
         ,$mail
         ,$dob
         ,$month
         ,$year
         ,$pincode
         ,$city
         ,$contact_number
         //$password

?>