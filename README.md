# DatabaseTask

HINDELINE ÜLESANNE 2

![image](https://github.com/JaagupPr/DatabaseTask/assets/158137390/3d1b2a8e-de82-4101-95c9-18d4198c7e05)

```json
OBJECT STRUCTURE:
{
  "Company": {
    "id": "integer",
    "registry_type": "string",
    "name": "string",
    "short_name": "string",
    "address": "string",
    "contact_person": "string",
    "contact_phone_number": "string",
    "contact_email": "string",
    "comment": "string"
  },
  "AdministrativeUnitType": {
    "id": "integer",
    "name": "string",
    "date_of_commissioning": "date",
    "date_of_liquidation": "date",
    "comment": "string"
  },
  "AdministrativeUnit": {
    "id": "integer",
    "administrative_unit_type_id": "integer",
    "name": "string",
    "first_name": "string",
    "surname": "string",
    "address": "string",
    "contact_email": "string",
    "creation_date": "date",
    "liquidation_date": "date",
    "comment": "string"
  },
  "Employee": {
    "id": "integer",
    "personal_code": "string",
    "name": "string",
    "surname": "string",
    "contact_address": "string",
    "contact_phone_number": "string",
    "contact_email": "string",
    "children_id": "integer",
    "employment_condition_id": "integer",
    "vacation_id": "integer",
    "sick_log_id": "integer",
    "health_checks_id": "integer",
    "anonymous_report_id": "integer",
    "requests_report_id": "integer",
    "administrative_unit_id": "integer"
  },
  "EmploymentCondition": {
    "id": "integer",
    "employee_id": "integer",
    "company_id": "integer",
    "administrative_unit_id": "integer",
    "job_type_id": "integer",
    "creation_date": "date",
    "liquidation_date": "date",
    "comment": "string"
  },
  "JobType": {
    "id": "integer",
    "employment_condition_id": "integer",
    "employee_id": "integer",
    "description": "string",
    "type": "string",
    "creation_date": "date",
    "liquidation_date": "date",
    "comment": "string"
  },
  "Children": {
    "id": "integer",
    "employee_id": "integer",
    "name": "string",
    "surname": "string",
    "personal_code": "string",
    "comment": "string"
  },
  "Vacations": {
    "id": "integer",
    "employee_id": "integer",
    "days": "integer",
    "start_date": "date",
    "end_date": "date",
    "comment": "string"
  },
  "SickLog": {
    "id": "integer",
    "employee_id": "integer",
    "days": "integer",
    "start_date": "date",
    "end_date": "date",
    "comment": "string"
  },
  "HealthChecks": {
    "id": "integer",
    "employee_id": "integer",
    "days": "integer",
    "health_status": "integer",
    "sick_log_id": "integer",
    "end_date": "date",
    "comment": "string"
  },
  "AnonymousReport": {
    "id": "integer",
    "employee_id": "integer",
    "date": "date",
    "description": "string",
    "comment": "string"
  },
  "RequestsReport": {
    "id": "integer",
    "employee_id": "integer",
    "contact_email": "string",
    "date": "date",
    "comment": "string"
  },
  "AccessPermissions": {
    "id": "integer",
    "administrative_unit_id": "integer",
    "employee_id": "integer",
    "rental_status": "string",
    "door_card": "string",
    "comment": "string"
  },
  "RentalItems": {
    "id": "integer",
    "access_permissions_id": "integer",
    "item": "string",
    "description": "string",
    "item_status": "string",
    "purchased_date": "date",
    "liquidation_date": "date",
    "comment": "string"
  },
  "RentalList": {
    "id": "integer",
    "access_permissions_id": "integer",
    "rental_items_id": "integer",
    "rental_status": "string",
    "rental_date": "date",
    "delivery_date": "date",
    "item_status": "string",
    "comment": "string"
  },
  "DoorCard": {
    "id": "integer",
    "key": "string",
    "start_date": "date",
    "end_date": "date",
    "comment": "string"
  }
}
```
