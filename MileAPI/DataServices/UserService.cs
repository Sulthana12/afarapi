﻿using MileAPI.Interfaces;
using MileDALibrary.Interfaces;
using MileDALibrary.Models;

namespace MileAPI.DataServices
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<LoginDetails> GetUserInformation(string PhoneNumber, string Password)
        {
            return _userRepository.GetUserInformation(PhoneNumber, Password);
        }

        public List<CountryDetails> GetCountryDetails()
        {
            return _userRepository.GetCountryDetails();
        }

        public List<StateDetails> GetStateDetails()
        {
            return _userRepository.GetStateDetails();
        }

        public List<DistrictDetails> GetDistrictDetails(int stateId, int countryId)
        {
            return _userRepository.GetDistrictDetails(stateId, countryId);
        }

        public List<VehicleDetails> GetVehicleDetails()
        {
            return _userRepository.GetVehicleDetails();
        }

        public List<GenderDetails> GetGenderDetails(string settingsName)
        {
            return _userRepository.GetGenderDetails(settingsName);
        }

        public IUserRepository Get_userRepository()
        {
            return _userRepository;
        }

        public List<ResponseStatus> DriverRegPaymentStatusDetails(DriverRegPaymentStatus DriverRegPaymentStatus)
        {
            return _userRepository.DriverRegPaymentStatusDetails(DriverRegPaymentStatus);
        }


        public List<DriverDetails> GetDriverDetails(string phoneNumber)
        {
            return _userRepository.GetDriverDetails(phoneNumber);
        }

        public Task<List<ResponseStatus>> SaveUserDetails(UserDetails userDetails)
        {
            return _userRepository.SaveUserDetails(userDetails);
        }

        public int SendEmail(string emailId, int otp)
        {
            return _userRepository.SendEmail(emailId, otp);
        }

        //public int SendMsg(string phonenum, int otp)
        //{
        //   return _userRepository.SendMsg(phonenum, otp);
        //}

        public List<LoginDetails> GetUpdatedProfile(int userId)
        {
            return _userRepository.GetUpdatedProfile(userId);
        }

        public List<ResponseStatus> SaveLocation(LocationDetails locationDetails)
        {
            return _userRepository.SaveLocation(locationDetails);
        }

        public List<LocationDetails> GetSavedLocation()
        {
            return _userRepository.GetSavedLocation();
        }

       public List<ResponseStatus> SaveBookingDetails(BookingDetails bookingDetails)
        {
            return _userRepository.SaveBookingDetails(bookingDetails);
        }

        public List<DriverNotification> GetDriverNotificationDetails()
        {
            return _userRepository.GetDriverNotificationDetails();
        }

        public Task<List<ResponseStatus>> DriverPaymentDetails(DriverPaymentDetails driverPaymentDetails)
        {
            return _userRepository.DriverPaymentDetails(driverPaymentDetails);
        }

        public List<GetDriverPaymentDetails> GetDriverPaymentDetails(int User_Id)
        {
            return _userRepository.GetDriverPaymentDetails(User_Id);
        }

        public List<ExpiredVehicleInsurance> GetExpiredDrvLicense(ExpiredVehicleDetails expiredVehicleDetails)
        {
            return _userRepository.GetExpiredDrvLicense(expiredVehicleDetails);
        }

        public List<ResponseStatus> AddReferralDetails(ReferralDetails ReferralDetails)
        {
            return _userRepository.AddReferralDetails(ReferralDetails);
        }

        public List<ResponseStatus> SMSGatewayStatus(AddSMSGatewayStatus AddSMSGatewayStatus)
        {
            return _userRepository.SMSGatewayStatus(AddSMSGatewayStatus);
        }

        public Task<List<ResponseStatus>> UpdateProfileDetails(UpdateProfile updateProfile)
        {
            return _userRepository.UpdateProfileDetails(updateProfile);
        }

        public List<UserByPhoneOrEmail> GetUserByPhoneOrEmail(string phone_num)
        {
            return _userRepository.GetUserByPhoneOrEmail(phone_num);
        }

        public List<ResponseStatus> UserPwdUpdate(UserDetails UserPwdUpdate)
        {
            return _userRepository.UserPwdUpdate(UserPwdUpdate);
        }
    }
}
