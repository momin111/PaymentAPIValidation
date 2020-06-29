Feature: APIValidationTest
	

@mytag
Scenario: Request with a valid JWT token
  Given I have the following request body:
  """
  {
    "bankAccount": "GB09HAOE91311808002317"
  }
  """  
  When I post this request with valid '' key to the '' api 
  Then the result should be  : "OK"


Scenario: Request without a JWT token
  Given I have the following request body:
  """
  {
    "bankAccount": "GB09HAOE91311808002317"
  }
  """  
  When I post this request with empty ' ' key to the '' api 
  Then the response body description should include: "Authorization has been denied for this request."

Scenario: Request with an invalid JWT token
  Given I have the following request body:
  """
  {
    "bankAccount": "GB09HAOE91311808002317"
  }
  """  
  When I post this request with invalid '' key to the '' api 
  Then the response body description for invalid JWT token should include : "Authorization has been denied for this request."

Scenario: Request IBAN number of Austria
  Given I have the following request body:
  """
  {
    "bankAccount": "AT61 1904 3002 3457 3201"
  }
  """  
  When I post this request of Austria IBAN with valid '' key to the '' api 
  Then Status Code for IBAN of Austria should be: (200)

Scenario: Request IBAN number of Germany
  Given I have the following request body:
  """
  {
    "bankAccount": "DE89 3704 0044 0532 0130 00"
  }
  """  
  When I post this request of Germany with valid '' key to the '' api 
  Then Status Code for IBAN of Germany should be: (200)

Scenario: Request IBAN number of Switzerland
  Given I have the following request body:
  """
  {
    "bankAccount": "CH 93 00762 011623852957"
  }
  """  
  When I post this request of Switzerland with valid '' key to the '' api 
  Then Status Code for IBAN of Switzerland should be: (200)

Scenario: Request IBAN number of Finland
  Given I have the following request body:
  """
  {
    "bankAccount": "FI2112345600000785"
  }
  """  
  When I post this request of Finland with valid '' key to the '' api 
  Then Status Code for IBAN of Finland should be: (200)

Scenario: Request IBAN number of Sweden
  Given I have the following request body:
  """
  {
    "bankAccount": "SE45 5000 0000 0583 9825 7466"
  }
  """  
  When I post this request of Sweden with valid '' key to the '' api 
  Then Status Code for IBAN of Sweden should be: (200)

Scenario: Request IBAN number of Norway
  Given I have the following request body:
  """
  {
    "bankAccount": "NO93 8601 1117 947"
  }
  """  
  When I post this request of Norway with valid '' key to the '' api 
  Then Status Code for IBAN of Norway should be: (200)

Scenario: Request IBAN number of Denmark
  Given I have the following request body:
  """
  {
    "bankAccount": "DK50 0040 0440 1162 43"
  }
  """  
  When I post this request of Denmark  with valid '' key to the '' api 
  Then Status Code for IBAN of Denmark should be: (200)

Scenario: Request In-valid IBAN number less than Seven character
  Given I have the following request body:
  """
  {
    "bankAccount": "AL3JK"
  }
  """  
  When I post this request of less than Seven character and invalid IBAN with valid '' key to the '' api 
  Then Message for In-valid IBAN number less than Seven character should be: "A string value with minimum length 7 is required."
 

Scenario: Request invalid but exactly Seven char IBAN with space character
Given I have the following request body:
  """
  {
    "bankAccount": "AL3J3 3"
  }
  """  
  When I post this request of invalid but exactly Seven char IBAN with space character with valid '' key to the '' api 
  Then Message for invalid but exactly Seven char IBAN with space character should be: "Value format is incorrect." 

Scenario: Request invalid but exactly Seven char IBAN with no space character
  Given I have the following request body:
  """
  {
    "bankAccount": "AL3J333"
  }
  """  
  When I post this request with invalid but exactly Seven char IBAN with no space character with valid '' key to the '' api 
  Then Message for invalid but exactly Seven char IBAN with no space character should be: "Value format is incorrect." 

Scenario: Request valid but not supported IBAN which contains exactly Thirty Four character 
  Given I have the following request body:
  """
  {
    "bankAccount": "AL35 2021 1109 0000 0000 0123 4567"
  }
  """  
  When I post this request with valid but not supported IBAN which contains exactly Thirty Four character  with valid '' key to the '' api 
  Then Response body for valid but not supported IBAN which contains exactly Thirty Four character  should contain: "false"

Scenario: Request valid but not supported IBAN which contains less than Thirty Four character
  Given I have the following request body:
  """
  {
    "bankAccount": "BE71 0961 2345 6769"
  }
  """  
  When I post this request with valid but not supported IBAN which contains less than Thirty Four character with valid '' key to the '' api 
  Then Response body for valid but not supported IBAN which contains less than Thirty Four character should contain: "false"

Scenario: Request Invalid IBAN which contains exactly Thirty Four character
  Given I have the following request body:
  """
  {
    "bankAccount": "ABDR121234567890123456789012345678"
  }
  """  
  When I post this request with Invalid IBAN which contains exactly Thirty Four character with valid '' key to the '' api 
  Then Response body for Invalid IBAN which contains exactly Thirty Four character should contain: "Value format is incorrect."

Scenario: Request invalid and more than Thirty Four char IBAN
  Given I have the following request body:
  """
  {
    "bankAccount": "ABDR12123456789012345678901234567890"
  }
  """  
  When I post this request with invalid and more than Thirty Four char IBAN with valid '' key to the '' api 
  Then The result for invalid and more than Thirty Four char IBAN should be :"Bad Request"
  And Response body for invalid and more than Thirty Four char IBAN should contain: "A string value exceeds maximum length of 34."

Scenario: Request with null or empty IBAN
  Given I have the following request body:
  """
  {
    "bankAccount": " "
  }
  """  
  When I post this request with null or empty IBAN with valid '' key to the '' api 
  Then Response body for null or empty IBAN should contain: "Value is required."

Scenario: Request with invalid IBAN
  Given I have the following request body:
  """
  {
    "bankAccount": "=="
  }
  """  
  When I post this request with invalid IBAN with valid '' key to the '' api 
  Then Response body for invalid IBAN should contain: "A string value with minimum length 7 is required"
