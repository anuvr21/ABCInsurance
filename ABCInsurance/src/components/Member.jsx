import React,{useState,useEffect} from 'react'

const Member = ({searchResults,setSearchResults}) => {
  
const [popUp, setPopUp]=useState(false);

const openPopup = () => {
  setPopUp(true);
};

const closePopup = () => {
  setPopUp(false);
};
  
  
  const handleDelete=async ()=>{
   
      try {
  
       
        const response = await fetch(`https://localhost:7087/api/web/${searchResults.member.memberUniquePersonKey}`,  { method: 'DELETE' });
        if (response.ok) {
          setSearchResults(null);
          
        }
  
 
  
      } catch (error) {
        throw error;
      }  }

      const isoDate = searchResults[0].member.memberDate;
      const dateObject = new Date(isoDate);
      const formattedDate = `${dateObject.getMonth() + 1}/${dateObject.getDate()}/${dateObject.getFullYear()}`;
      console.log(formattedDate);
      
  return (

 
    <div className='m-container'>
      <div className='heading'
>
        <h2>Member Details</h2>
        <a href="#" onClick={openPopup}>Delete Member</a>
        </div>
        {
          popUp && <>
                  <div className="modal" onClick={closePopup}></div>
      <div className="popup">
      <div className="popup-content">
      <div className="popup-message">
    <p>Are you sure you want to delete?</p>
      </div>
      <div className="button-group">
      <button className="close-button" onClick={closePopup}>
          Close
        </button>
        <button className="delete-button" onClick={handleDelete}>
          Delete
        </button>
      </div>
        
      </div>
    </div></>
        }

    
       
        <div className='member-details'>
            <div className="l-detail">
            <p className='name'>{searchResults[0].member.memberFirstName+ " " +searchResults[0].member.memberLastName}</p>
            <p className='dob'><strong>DOB: </strong>{formattedDate} </p>
            <p><strong>Address: </strong></p>
            <p className='address'>{searchResults[0].member.memberaddress+", "+searchResults[0].member.membercity+", "+searchResults[0].member.memberstate}</p>
            </div>
            <div className="r-detail">

                <p><strong>Gender: </strong>{searchResults[0].member.memberGender==="F"?"Female":"Male"}</p>
                <p><strong>Phone: </strong>{searchResults[0].member.memberPhone}</p>
            </div>
       

        </div>
        
    </div>
  )
}

export default Member