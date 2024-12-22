import PropTypes from 'prop-types';

const Box = ({ children, className //, ...others 
}) => {
  return (
    <div className={` ${className}`} //{...others}
    >
      {children}
    </div>
  );
};

Box.propTypes = {
  children: PropTypes.Object,
  className: PropTypes.String
}
export default Box;
