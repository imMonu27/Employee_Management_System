using Employee_Management_System.DTO;

namespace Employee_Management_System.Interface
{
    public interface IEmployeeAdditionalDetails
    {
        Task<EmployeeAdditionalDetailsDTO> Add_AdditionalData(EmployeeAdditionalDetailsDTO employeeDetails);
        Task<List<EmployeeAdditionalDetailsDTO>> GetAllEmployeeAdditionalData();

        Task<EmployeeAdditionalDetailsDTO> GetEmployeeAdditionalDataByUId(string uId);

        Task<EmployeeAdditionalDetailsDTO> UpdateAdditionalData(EmployeeAdditionalDetailsDTO employeeDetails);

        Task<string> DeleteEmployeeAdditional(string UId);

       
    }
}
