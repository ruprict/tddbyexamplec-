require 'TestCase'
class WasRun<TestCase
	
	def testMethod
		puts "*** WasRun.testMethod"
		puts "*** log="+@log
		@log = @log+"testMethod "
		puts '*** log='+@log
		puts "*** end WasRun.testMethod"
	end
end
